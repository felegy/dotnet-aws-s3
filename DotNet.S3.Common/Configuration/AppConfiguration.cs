using Microsoft.Extensions.Configuration;

namespace DotNet.S3.Common
{
	public class AppConfiguration : IAppConfiguration
	{
		public string BucketName { get; set; }
		public string Region { get; set; }
		public string AwsAccessKey { get; set; }
		public string AwsSecretAccessKey { get; set; }
		public string AwsSessionToken { get; set; }

        public AppConfiguration(IConfiguration configuration)
        {
            configuration.GetSection("S3").Bind(this);
        }
	}
}
