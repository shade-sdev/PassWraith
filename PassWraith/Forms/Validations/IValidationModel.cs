using System.Threading.Tasks;

namespace PassWraith.Forms.Validations
{
    public interface IValidationModel<T, U>
    {
        T BuildValidationModel();

        U BuildEntity();

        void LoadForm(U entity);

        Task SaveForm();
    }
}
