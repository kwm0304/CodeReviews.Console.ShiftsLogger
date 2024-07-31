using Client.Utils;
using Server.Models;
using Shared;
using Shared.Enums;

namespace Client.Views;

public class SelectionMenus
{
  public static string genericPrompt = "What would you like to do?";
  public static Employee SelectEmployee(List<Employee> employees)
  {
    var menu = new BasePrompt<Employee>("Select an employee to view details", employees);
    return menu.Show()!;
  }

  public static Shift SelectShift(List<Shift> shifts)
  {
    var menu = new BasePrompt<Shift>("Select a shift to view details", shifts);
    return menu.Show()!;
  }

  public static EmployeeShift SelectEmployeeShift(List<EmployeeShift> employeeShifts)
  {
    var menu = new BasePrompt<EmployeeShift>("Select an employee-shift to view details", employeeShifts);
    return menu.Show()!;
  }

  public static ShiftClassification SelectShift(List<ShiftClassification> shifts)
  {
    var menu = new BasePrompt<ShiftClassification>("What shift would you like to assign?", shifts);
    return menu.Show();
  }

  public static string MainMenu()
  {
    var menuOptions = new List<string> { "View employees", "View shifts", "Exit" };
    var menu = new BasePrompt<string>(genericPrompt, menuOptions);
    return menu.Show()!;
  }

  public static string EmployeeMenu()
  {
    var menuOptions = new List<string> { "Add employee", "View employees", "Back" };
    var menu = new BasePrompt<string>(genericPrompt, menuOptions);
    return menu.Show()!;
  }

  public static string ShiftMenu()
  {
    var menuOptions = new List<string> { "Add shift", "View shifts", "Back" };
    var menu = new BasePrompt<string>(genericPrompt, menuOptions);
    return menu.Show()!;
  }

  public static string EmployeeOptionsMenu()
  {
    var menuOptions = new List<string> { "View all shifts for employee", "View employees pay", "Edit employee attributes", "Delete employee", "Back" };
    var menu = new BasePrompt<string>(genericPrompt, menuOptions);
    return menu.Show()!;
  }

  public static string ShiftOptionsMenu()
  {
    var menuOptions = new List<string> { "View all employees on shift", "View late employees on shift", "Edit shift attributes", "Delete shift", "Back" };
    var menu = new BasePrompt<string>(genericPrompt, menuOptions);
    return menu.Show()!;
  }

  public static string SelectEmployeePayRange()
  {
    var menuOptions = new List<string> {"Day", "Week", "Month", "Year"};
    var menu = new BasePrompt<string>("What pay range do you want to view?", menuOptions);
    return menu.Show()!;
  }

  public static string EmployeeEditSelection()
  {
    var menuOptions = new List<string>{"Name", "Shift", "Pay", "Back"};
    var menu = new BasePrompt<string>("What attribute would you like to edit?", menuOptions);
    return menu.Show()!;
  }
}