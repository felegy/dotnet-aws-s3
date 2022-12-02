namespace DotNet.S3.Common
{
	public interface IAppConfiguration
	{
		string AwsAccessKey { get; }
		string AwsSecretAccessKey { get; }
		string AwsSessionToken { get; }
		string BucketName { get; }
		string Region { get; }
	}
}
