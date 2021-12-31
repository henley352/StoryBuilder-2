using Microsoft.Extensions.DependencyInjection;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoryBuilder.ViewModels;
using StoryBuilder.Models;  


namespace StoryBuilderTests
{
    [TestClass]
    public class CreateProjectTests
    {
        [TestMethod]
        public async void CreateBlankProject() {
            ShellViewModel shell = Ioc.Default.GetService<ShellViewModel>();
            UnifiedVM vm = new UnifiedVM();
            vm.ProjectName = "NewProjectTest";
            vm.ProjectPath = @"C:\dev\src\StoryBuilder\StoryBuilderTests\TestResults";
            vm.SelectedTemplate = "Blank Project";
            await shell.UnifiedNewFile(vm);
            //Assert(manually created file is identical to the file I just created in code)
        }
    }
}
