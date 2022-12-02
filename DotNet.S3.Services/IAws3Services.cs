using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DotNet.S3.Services
{
	public interface IAws3Services
	{
		Task<byte[]> DownloadFileAsync(string file);

		Task<bool> UploadFileAsync(IFormFile file);

		Task<bool> DeleteFileAsync(string fileName, string versionId = "");
	}
}
