namespace DotNet.S3.Infrastructure.Configuration;

public interface IS3Configuration
{
    string AwsAccessKey { get; init; }

    string AwsSecretAccessKey { get; init; }

    string AwsSessionToken { get; init; }

    string BucketName { get; init; }

    string Region { get; init; }
}
