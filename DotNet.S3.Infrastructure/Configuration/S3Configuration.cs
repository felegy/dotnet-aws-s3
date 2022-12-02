using Microsoft.Extensions.Configuration;

namespace DotNet.S3.Infrastructure.Configuration;

public class S3Configuration : IS3Configuration
{
    public string BucketName { get; init; } = string.Empty;

    public string Region { get; init; } = "eu-west-1";

    public string RegionEndpoint { get; init; } = string.Empty;

    public string AwsAccessKey { get; init; } = string.Empty;

    public string AwsSecretAccessKey { get; init; } = string.Empty;

    public string AwsSessionToken { get; init; } = string.Empty;

    public S3Configuration(IConfiguration configuration)
    {
        configuration.GetSection("S3").Bind(this);
    }
}
