using System.Threading.Tasks;
using System;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;
using PassWraith.Data;
using System.Linq;
using System.Data.Entity;
using PassWraith.Data.Entities;

public class SchedulerService
{
    private readonly IServiceProvider serviceProvider;
    private readonly IPassWraithContext _context;
    private static Timer timer;
    private CancellationTokenSource cancellationTokenSource;

    public SchedulerService(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
        this._context = this.serviceProvider.GetRequiredService<IPassWraithContext>();

        timer = new Timer(RemoveDeletedCredentialsSchedular, null, Timeout.Infinite, Timeout.Infinite);
        cancellationTokenSource = new CancellationTokenSource();
    }

    public void StartRemoveDeletedCredentialsJob()
    {
        timer.Change(TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(5));
    }

    private async void RemoveDeletedCredentialsSchedular(object state)
    {
        try
        {
            await RemoveDeletedCredentialsJob(cancellationTokenSource.Token);
        }
        catch (Exception ex)
        {
            // Handle the exception as needed
        }
    }

    private async Task RemoveDeletedCredentialsJob(CancellationToken cancellationToken)
    {
        DateTime thirtyDaysAgo = DateTime.Today.AddDays(-30).Date;

        IQueryable<PasswordEntity> query = _context.passwords
            .Where(it => it.IsDeleted && it.DeletedDate.HasValue &&
                it.DeletedDate.Value < thirtyDaysAgo);

        var passes = await query.ToListAsync();

        foreach (var password in passes)
        {
            _context.DeleteById(password.Id);
        }

        cancellationToken.ThrowIfCancellationRequested();
    }


    private void StopRemoveDeletedCredentialsJob()
    {
        // Stop the timer and cancel any ongoing tasks
        timer.Change(Timeout.Infinite, Timeout.Infinite);
        cancellationTokenSource.Cancel();
    }


}
