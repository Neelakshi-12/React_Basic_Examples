class Restaurant
{
  public void useIngredients()
  {
  System.out.println("In Restaurant : uses these Ingredients");
  }
  public void useVegetables()
  {
  System.out.println("In Restaurant : uses these Vegetables.");
  }
}
class Chinese extends Restaurant
{
  public void servessnoodles()
  {
  System.out.println("It's Chinese : the serves noodles ");
  }
}
class Mexican extends Restaurant
{
  public void servesnachosandpotatoes()
  {
    System.out.println("It's Mexican : they serves nachos and potatoes");
  }
}
class Italian extends Restaurant
{
  public void servesPasta()
  {
    System.out.println("It's Italian : they serves pasta");
  }
}
public class HierarchialInheritance {

	public static void main(String[] args) {
		Chinese chinese = new Chinese();
		Mexican mexican = new Mexican();
		Italian italian = new Italian();
		 System.out.println("It's Chinese");
			chinese.useIngredients();
			chinese.useVegetables();
		    chinese.servessnoodles();
		    System.out.println("******************");  
		 System.out.println("It's Mexican");
		 chinese.useIngredients();
			chinese.useVegetables();
		  
		    mexican.servesnachosandpotatoes();
		    System.out.println("******************"); 
		 System.out.println("It's Italian");
		chinese.useIngredients();
		chinese.useVegetables();
		italian.servesPasta();
		 System.out.println("******************"); 
	  }

}


