using MetroSuite;
using System.Diagnostics;
using System.Threading;

public partial class MainForm : MetroForm
{
    public MainForm()
    {
        InitializeComponent();
    }

    public static void ExecuteAsAdmin(string fileName, string arguments)
    {
        Process proc = new Process();
        proc.StartInfo.FileName = fileName;
        proc.StartInfo.Arguments = arguments;
        proc.StartInfo.UseShellExecute = true;
        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        proc.StartInfo.CreateNoWindow = true;
        proc.StartInfo.Verb = "runas";
        proc.Start();
        proc.WaitForExit();
    }

    private void gunaButton1_Click(object sender, System.EventArgs e)
    {
        gunaButton1.Enabled = false;
        new Thread(() =>
        {
            ExecuteAsAdmin("D:\\Games\\Steam\\steamapps\\common\\Paladins\\Binaries\\Win32\\Paladins.exe", "-homedir=paladinslive -EACALT -seekfreeloadingpcconsole -allow64 -LANGUAGE=ITA -EACALT -allow64 -pid=402 -eac-nop-loaded -region=Earth -portaluserid=BLOCKED -token=BLOCKED -Steam -HEXX=BLOCKED");
        }).Start();
    }
}