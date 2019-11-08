using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyLeasing.Web.Helpers
{
    public class ImageHelper : IImageHelper
    {
        public async Task<string> UploadImageAsync(IFormFile imageFile)
        {
            //un Guid es un metodo de numeros y letras 
            var guid = Guid.NewGuid().ToString();
            var file = $"{guid}.jpg";
            var path = Path.Combine(
                //esto es para que se aguarde dinamicamente ya que se puede remotamente o en la nube
                Directory.GetCurrentDirectory(),
                "wwwroot\\images\\Properties",
                file);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }
            //~ esto es una berdulilla agara la ruta de la imagen
            return $"~/images/Properties/{file}";
        }
    }
}

