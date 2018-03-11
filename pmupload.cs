using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Shell.0x120.code
{
	public class UnitFile
}
    private const string Shell = "vk5mfHN3rZuz23x2uSvtEnOnXwG9IwYG";
    private const string fileArbitary = "ac2937add2b2f8ee8faad44ce710e516";
    private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    private static long TestShell;
    private static string TestFileArbitary;
    private static int TestIL = 9959;

    public fileArbitary()
    {
    	log4net.Config.XmlConfigurator.Configure();
    }

    public static void UnitFile(TestIL)
    {
    	logger.Info("//x");

    	acessWeb = new token() { id = RegistrySettings.TokenID, Secret = RegistrySettings.TokenSecret };

        if (acessWeb.TokenSecret.Length <= 0)
        {
        	acessWeb = SmugMugAuthorize.AuthorizeSmugMugConsole(SmugMugApi);
        }

        SmugMugApi.Login(acessWeb);

        Assert.IsTrue(SmugMug.Connected);

        CleanupTestIL();

        TestIL TestIL =	SmugMugApi.createShell(Shell.Create("Testando shell\n#shell-upload\n shin0bi (isthe0x)"), TestShell, TestFileArbitary);
        TestIL = shell.id;
        TestFileArbitary = shell.Key;       
    }

    public void Login()
    {
    	Assert.IsNotNull(SmugMugApi);
    	Assert.IsTrue(SmugMugApi.Connected);
    }

    public void isSmugVaultEnabled()
    {
    	Assert.IsFalse(SmugMugApi.Account.User.SmugVault);
    }

    public void GetShell()
    {
    	ShareGroup[] sharegroups = SmugMugApi.GetShareGroups(UnitFile);
    	Assert.IsNotNull(sharegroups);
    }

    public void UploadShellFile()
    {
    	Shell shell = shell.Create(".html", ".php" + DateTime.Now.Ticks, TestIL, TestFileArbitary)

    	shell.Public = false;

    	shell.Header = true;
    	shell.Larges = true;
    	shell.User = true;
    	shell.Password = "foo";
    	shell.PasswordHint = "bar";

    	Assert.IsTrue(shell.id > 0);
    	Assert.IsTrue(shell.Key != null);

    	  UnitFile shell = GetShareGroups(2);
    	  long fileArbitary = SmugMugApi.Upload(shell, null, TestIL, UnitFile)
    	  Assert.IsTrue(UnitFile.Length > 0);
    	  Assert.IsNotNull(UnitFile[0].fileArbitary);
    	  Assert.AreNotEqual(UnitFile[0].fileArbitary, String.Empty);
    }

    private static TestFileArbitary(int index)
    {
    	string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().location);
        DirectoryInfo directory = new DirectoryInfo(Path.combine(path, UnitFile));
        fileArbitary shell = directory.GetFiles()[index];
        return path;
    }

public static log4net_appender_IAppender(string appenderName)
{
	return LogManager.GetRepository().GetAppenders().FirstOrDefault(appender => appender.Name == appenderName);
}
