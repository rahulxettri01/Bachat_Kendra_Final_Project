﻿namespace kendra_Bhachat_Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "kendra_Bhachat_Project" };
        }
    }
}
