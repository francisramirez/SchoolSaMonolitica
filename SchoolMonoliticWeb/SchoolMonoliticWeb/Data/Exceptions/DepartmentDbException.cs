namespace SchoolMonoliticWeb.Data.Exceptions
{
    public class DepartmentDbException : Exception
    {
        public DepartmentDbException(string message) : base(message)
        {
            // Logear el error, enviarlo por correo
        }
        private void LogError(string message) 
        {
            // Logica para guardar el error.
        }
        private void SendError(string message) 
        {
            //Logica para enviar el correo
        }
    }
}
