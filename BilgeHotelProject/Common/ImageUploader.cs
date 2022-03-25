using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ImageUploader
    {
        public static IResult UploadImage(string serverPath, IFormFile file, Result result)
        {
            if (file!=null)
            {
                string extension = Path.GetExtension(file.FileName).ToLower();
                if ((new[] { ".png", ".jpg", ".jpeg" }.Contains(extension)))
                {
                    var uniqueName = Guid.NewGuid();
                    string fileName = uniqueName + extension;

                    try
                    {
                        using (FileStream fileStream = File.Create("wwwroot"+serverPath + fileName))
                        {
                            file.CopyTo(fileStream);

                            result.ResultStatus = ResultStatus.Success;
                            result.Message = serverPath + fileName;
                            return result;
                        }
                    }
                    catch (Exception ex)
                    {
                        result.ResultStatus = ResultStatus.Error;
                        result.Exception = ex;
                        result.Message = ex.Message;
                        return result;
                    }
                }
                else
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "Dosya uzantısı geçerli değil. png, jpg veya jpeg uzantılı dosya ekleyebilirsiniz.";
                    return result;
                }
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Dosya boş. Lütfen yüklediğinizden emin olun.";
                return result;
            }
        }
    }
}
