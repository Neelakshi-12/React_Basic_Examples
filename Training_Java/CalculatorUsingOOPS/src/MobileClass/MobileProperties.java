package MobileClass;

class Properties{
	
	//defining a method
	void show() {
		System.out.println("Color of Mobile is Black");
	}
}

 class MobileProperties extends Properties {
	 void show() {
		 System.out.println("Color of Mobile is Red");
	 }

	public static void main(String[] args) {
		MobileProperties obj = new MobileProperties(); //creating object
		obj.show(); //calling method
	}

}
