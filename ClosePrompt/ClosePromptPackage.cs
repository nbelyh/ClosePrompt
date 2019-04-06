using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace ClosePrompt
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("Close Prompt", "Shows confirmation prompt message to confirm exit", "ClosePrompt.14CE444A-AE6B-446C-93F4-91733D57E939")]
    [Guid(PackageGuidString)]
    [ProvideAutoLoad(UIContextGuids80.NoSolution, PackageAutoLoadFlags.BackgroundLoad)]
    public sealed class ClosePromptPackage : Package
    {
        public const string PackageGuidString = "b79e2775-1c62-459d-b623-31b93818fe8d";

        protected override int QueryClose(out bool canClose)
        {
            canClose = MessageBox.Show("Do you want to close Visual Studio?", "Close Prompt Extension", MessageBoxButtons.OKCancel) == DialogResult.OK;
            return 0;
        }
    }
}
