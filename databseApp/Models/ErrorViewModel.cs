using System;

namespace databseApp.Models
{
    public class ErrorViewModel
    {
        public string ErrorId{ get; set; }

        public bool ShowErrorId=> !string.IsNullOrEmpty(ErrorId);
    }
}
