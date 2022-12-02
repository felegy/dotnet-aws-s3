using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DotNet.S3.Common
{
	public interface IDocumentStore
	{
		byte[] DownloadDocument(string documentName);

		bool UploadDocument(IFormFile file);

		bool DeleteDocument(string fileName, string versionId = "");
	}
}
