namespace Application.Models.Keycloak;

public class Credential
{
    public string Type { get; set; }
    public string Value { get; set; }
    public bool Temporary { get; set; }
}