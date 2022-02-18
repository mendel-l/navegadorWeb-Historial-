using Microsoft.Web.WebView2.Core;
using System;
using System.Windows.Forms;
using System.IO;

namespace navegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView21.NavigationStarting += WebView21_NavigationStarting;
            InitializeAsync();
        }

        private void WebView21_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
        }

        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.WebMessageReceived += ActualizarBarraDireccion;

            await webView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            await webView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");

        }

        void ActualizarBarraDireccion(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            addressBar.Text = uri;
            //webView21.CoreWebView2.PostWebMessageAsString(uri);
        }

        private void Read(String pathIn)
        {
            FileStream stream = new FileStream(pathIn, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() < -1)
            {
                string texto = reader.ReadLine();
                addressBar.Items.Add(addressBar.Text);
            }
            reader.Close();
        }

        private void Save(string nombreArchivo, string texto)
        {
            //FileStream stream = new FileStream(nombreArchivo, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new /*StreamWriter(stream);*/StreamWriter(nombreArchivo, true);

            writer.WriteLine(texto);
            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoANavegar = addressBar.Text;

            Save(@"historialNavegacion.txt", addressBar.Text);
            //el txt. se guarda en la ubicacion donde esta creado el archivo en la carpeta bin/Debug en esta ultima se encuentra el archivo txt.

            if (textoANavegar.StartsWith("https://www.google.com/search?q=") == false)
            {
                addressBar.Items.Add("https://www.google.com/search?q=" + addressBar.Text);
            }
            //addressBar.Items.Add(addressBar.Text);

            // es una direccion
            if (textoANavegar.Contains(".com") || textoANavegar.Contains("http") ||
                textoANavegar.Contains("www"))
            {
                if (textoANavegar.StartsWith("https://") == false
                    && textoANavegar.StartsWith("http://") == false)
                {
                    textoANavegar = "https://" + textoANavegar;
                }

                webView21.CoreWebView2.Navigate(textoANavegar);
            }
            // es una palabra
            else
            {
                webView21.CoreWebView2.Navigate("https://www.google.com/search?q=" + textoANavegar);
            }

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void siguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void anteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Read(@"historialNavegacion.txt");
            //Read(@"Y:\A LA UNI cap3\PROGRAMACION\Laboratorios\Laboratorio #3\navegadorHistorial\navegadorWeb\bin\Debug\historialNavegacion.txt");
        }

        private void addressBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Read(@"historialNavegacion.txt");
            //Read(@"Y:\A LA UNI cap3\PROGRAMACION\Laboratorios\Laboratorio #3\navegadorHistorial\navegadorWeb\bin\Debug\historialNavegacion.txt");
        }
    }
}
