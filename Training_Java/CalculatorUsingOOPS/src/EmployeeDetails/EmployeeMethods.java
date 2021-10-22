package EmployeeDetails;

public class EmployeeMethods {
	
		   private int empId;
		   private String name;
		   private int salary;
		   private int age;
		   private String dept;

		   public int getEmpId()
		   {
		      return empId;
		   }
		   public String getName()
		   {
		      return name;
		   }
		   public int getSalary()
		   {
		      return salary;
		   }
		   public int getAge()
		   {
		      return age;
		   }
		   public String getDept()
		   {
		       return dept;
		   }
		   public void setEmpId( int empId)
		   {
		      this.empId = empId;
		   }
		   public void setName(String name)
		   {
		      this.name = name;
		   }
		   public void setSalary( int salary)
		   {
		      this.salary = salary;
		   }
		   public void setAge( int age)
		   {
		      this.age = age;
		   }
		   public void setDept(String dept)
		   {
		       this.dept = dept;
		   }
}