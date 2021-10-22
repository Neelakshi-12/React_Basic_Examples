import java.util.Scanner;
class humanbeing
{
    Scanner s=new Scanner(System.in);
    String name;

}
class employee extends student
{
    double monthly_salary;
    String designation;
    int id;
    employee(double monthly_salary,String designation,int emp_id,String empname,String phonenum)
    {
       this.emp_id=emp_id;
       this.empname=empname;
       this.phonenum=phonenum;
       this.designation=designation;
       this.monthly_salary=monthly_salary;
    }   
    void condition()
    {
        System.out.println("monthly salary is:"+monthly_salary);
        if(monthly_salary>10000)
        {
            System.out.println("name of employee is::"+empname);
            System.out.println("id of employee is::"+emp_id);
            System.out.println("phone number of employee is::"+phonenum);
            System.out.println("designation of employee is::"+designation);
        }
        else
        {
            System.out.println("Cannot display details....");
        }
    }
    
}
public class SingleInheritance {

	public static void main(String args[])
    {
        Scanner s=new Scanner(System.in);
        int id,i;
        String name,desig,phonenum;
        double sal;
        for(i=0;i<3;i++)
        {
            System.out.println("enter id of employee..");
            id=s.nextInt();
            System.out.println("enter name of person..");
            name=s.next();
            System.out.println("enter designation of employee...");
            desig=s.next();
            System.out.println("enter salary of employee");
            sal=s.nextDouble();
            System.out.println("enter phone of employee..");
            phonenum=s.next();
            employee x=new employee(sal,desig,id,name,phonenum);
            x.condition();
        }    

    }

}
