using System;
using System.Net; 

namespace FastF12
{
    public class DistributedRender
    {
        public WebClient web = new WebClient();

        public BlendFile getJob()
        {
            return null;
        }

        public void download()
        {
            WebClient Client = new WebClient();
            web.DownloadFile("http://api.nystic.com/", "index.php");
        }
        public void upload()
        {
            //Client.UploadFile
        }
    }
}
