using DownloadFile;
using System.Net;


String yy = "\"https://m.apkpure.com/apkpure/com.apkpure.aegon/download?from=profile&icn=aegon&ici=image_profile&refapk=com.google.android.youtube&utm_content=1017";
void downloadFile(string url)
{
    using (WebClient webClient = new WebClient())
    {
        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(delegate (object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine("Downloaded:" + e.ProgressPercentage.ToString());
        });

        webClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler
            (delegate (object sender, System.ComponentModel.AsyncCompletedEventArgs e)
            {
                if (e.Error == null && !e.Cancelled)
                {
                    Console.WriteLine("Download completed!");
                }
            });
        webClient.DownloadFileAsync(new Uri("http://www.example.com/file/test.jpg"), "test.jpg");
    }
}

downloadFile(yy);