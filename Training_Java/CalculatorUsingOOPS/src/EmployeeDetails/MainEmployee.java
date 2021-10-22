
package EmployeeDetails;
import java.util.*;
public class MainEmployee {

	 public static void main(String args[])
	    {
		    Scanner scanner = new Scanner(System.in);
	
		    System.out.println("Enter number of Employees :");
		    int numberInput = scanner.nextInt();
	        System.out.println("Enter details of " + numberInput + " Employees to View Details");
		    for (int i = 0; i < numberInput; i++) {
		      
				 EmployeeMethods emp = new EmployeeMethods();
				 	int empid;
				 	String name;
				 	int salary;
				 	int age;
				 	String dept;
				  Scanner in = new Scanner(System.in);
				  System.out.println("\n **** Enter Employee Details **** \n");
				  System.out.print("Enter the empid :: ");
				  empid = in.nextInt();
				  System.out.print("Enter the name :: ");
				  name = in.next();
				  System.out.print("Enter the salary :: ");
				  salary = in.nextInt();
				  System.out.print("Enter Age :: ");
				  age = in.nextInt();
				  System.out.print("Enter the Department :: ");
				  dept = in.next();
				 
				 
				  emp.setEmpId(empid);
			      emp.setName(name);
			      emp.setSalary(salary);
			      emp.setAge(age);
			      emp.setDept(dept);
			     
			      System.out.println("\n **** After getting Employee Details **** \n");
			      System.out.println("Employee Id : "+emp.getEmpId() + "\nName : " + emp.getName() + "\nSalary : " + emp.getSalary() + "\nAge : " + emp.getAge() + "\nDepartment : "+emp.getDept());
			      scanner.nextLine(); // handle the next line character (enter key)
		    }
		    
	         scanner.close();
	    }
}

