using Microsoft.Web.WebView2.Core;
using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace navegadorWeb
{
    public partial class Form1 : Form
    {
        List<HistorialURLs> URLs = new List<HistorialURLs>();
        string nombreArchivo = "Historial.txt";
        public Form1()
        {
            InitializeComponent();
            webView21.NavigationStarting += WebView21_NavigationStarting;
            InitializeAsync();

            Read();
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
        }

        private void Save()
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach(HistorialURLs dato in URLs )
            {
                var lineaAAGregar = dato.texto + "|" + dato.numero + "|" + dato.fecha.ToString("yyyy-MM-dd HH:mm:ss");
                writer.WriteLine(lineaAAGregar);
            }

            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoANavegar = "";
            if (addressBar.Text != null)
            {
                textoANavegar = addressBar.Text;
            }
            else if (addressBar.SelectedItem != null)
            {
                textoANavegar = addressBar.SelectedItem.ToString();
            }
            if (!textoANavegar.Contains("."))
            {
                textoANavegar = "https://www.google.com/search?q=" + textoANavegar;
            }
            if (!textoANavegar.Contains("https://"))
            {
                textoANavegar = "https://" + textoANavegar;
            }
            //texto a usar
            AgregaralHitorial(textoANavegar);
          
            webView21.CoreWebView2.Navigate(textoANavegar);
        }

        public void AgregaralHitorial(string texto)
        {
            int posicion = URLs.FindIndex(n => n.texto == texto);

            if (posicion == -1)
            {
                HistorialURLs dato = new HistorialURLs();
                dato.numero = 1;
                dato.texto = texto;
                dato.fecha = DateTime.Now;

                URLs.Add(dato);
            }
            else
            {
                URLs[posicion].numero++;
                URLs[posicion].fecha = DateTime.Now;
            }

            MostrarDatos();
            Save();
        }

        private void MostrarDatos()
        {
            // ordenar del mas visitado al menos visitado
            URLs = URLs.OrderByDescending(x => x.numero).ToList();

            // agregar al combo
            addressBar.Items.Clear();
            addressBar.Items.AddRange(URLs.Select(x => x.texto).ToArray());
            addressBar.Refresh();            
        }
    
        private void Read()
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new HistorialURLs();
                dato.texto = partes[0];
                dato.numero = int.Parse(partes[1]);
                dato.fecha = DateTime.Parse(partes[2]);      
                
                URLs.Add(dato);
            }

            reader.Close();
            MostrarDatos();
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
            //Read("Historial.txt");
        }
        private void addressBar_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
