namespace Application.Models.Keycloak;

using System.Text.Json.Serialization;

public class AuthToken
{
    [JsonPropertyName("access_token")] public string AccessToken { get; set; }

    [JsonPropertyName("expires_in")] public int ExpiredIn { get; set; }

    [JsonPropertyName("refresh_expires_in")] public int RefreshExpiresIn { get; set; }

    [JsonPropertyName("token_type")] public string TokenType { get; set; }

    [JsonPropertyName("not-before-policy")] public int NotBeforePolicy { get; set; }

    [JsonPropertyName("scope")] public string Scope { get; set; }
}