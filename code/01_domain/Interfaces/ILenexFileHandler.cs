using System.Threading.Tasks;
using Dom = Lenex.Domain.Entities;

namespace Lenex.Domain.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILenexFileHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="LenexFileName"></param>
        /// <returns></returns>
        public Task<Dom.Lenex> ReadLenexFile(string LenexFileName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LenexDataString"></param>
        /// <returns></returns>
        public Task<Dom.Lenex?> ReadLenexString(string LenexDataString);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LenexObj"></param>
        /// <param name="outputPath"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public Task WriteLenexFile(Dom.Lenex LenexObj, string outputPath, string fileName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LenexObj"></param>
        /// <returns></returns>
        public Task<string> GetLenexFileString(Dom.Lenex LenexObj);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LenexObj"></param>
        /// <returns></returns>
        public string GetLenexFileName(Dom.Lenex LenexObj);
    }
}
