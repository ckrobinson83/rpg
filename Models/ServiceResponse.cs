namespace rpg.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; } //This is your actual character data and the T is a generic.

        public bool Success { get; set; } = true;

        public string Message { get; set; } = null; //Send a message in case there was an error or other info


    }
}