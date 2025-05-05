namespace star_wars_api_project
{

    public struct PlanetApiData
    {
        public int count { get; set; }
        public string next { get; set; }

        public string? previous { get; set; }

        public List<PlanetSchema> results { get; set; }
    }
}