using GeometryGym.Ifc;
using System.IO;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			DatabaseIfc db = new DatabaseIfc(ModelView.Ifc2x3Coordination);

			IfcSite site = new IfcSite(db, "Default Site");
			IfcProject project = new IfcProject(site, "Default Project", IfcUnitAssignment.Length.Metre) { };
			IfcBuilding building = new IfcBuilding(site, "Default Building");
			IfcBuildingStorey buildingStorey = new IfcBuildingStorey(building, "SitePlan", 0.0);

			DirectoryInfo di = Directory.GetParent(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
			di = Directory.GetParent(di.FullName);
			db.WriteFile(Path.Combine(di.FullName, "ConsoleApp1.ifc"));
		}
	}
}
