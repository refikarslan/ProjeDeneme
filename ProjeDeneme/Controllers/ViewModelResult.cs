namespace ProjeDeneme.Controllers
{
    internal class ViewModelResult
    {
        private bool v1;
        private string v2;
        private List<string> errors;

        public ViewModelResult(bool v1, string v2, List<string> errors)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.errors = errors;
        }
    }
}