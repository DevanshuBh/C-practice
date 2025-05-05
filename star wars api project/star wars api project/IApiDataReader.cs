namespace star_wars_api_project
{
    public interface IApiDataReader
    {
        public Task<string> Read(string baseAddress, string requestUri);

    }
}