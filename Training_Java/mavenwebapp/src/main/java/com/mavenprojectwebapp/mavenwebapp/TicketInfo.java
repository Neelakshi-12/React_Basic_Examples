package com.mavenprojectwebapp.mavenwebapp;

import jakarta.ws.rs.GET;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.PathParam;
import jakarta.ws.rs.Produces;
import jakarta.ws.rs.core.MediaType;
import jakarta.ws.rs.FormParam;
import jakarta.ws.rs.MatrixParam;
import jakarta.ws.rs.POST;
import jakarta.ws.rs.QueryParam;


@Path("/info")
public class TicketInfo {
   /*http://localhost:8081/mavenwebapp/webapi/info/insertpath/movie/startup/delhi/2000*/
	@Path("/insertpath/{ticket_type}/{name}/{location}/{price}")
	@GET
	@Produces(MediaType.TEXT_PLAIN)
	public String recieveTicketinfo(@PathParam("ticket_type")String type,
		@PathParam("name")String name,
		@PathParam("location")String location,
		@PathParam("price")String price)
	{
		if(type!=null&&name!=null&&location!=null&&price!=null)
		{
			System.out.println(type+""+name+""+location+""+price);
			return "success";
		}
		else
			return "fail";
		
		
	
}
	

@Path("/query")
@GET
@Produces(MediaType.APPLICATION_XML)
public String insertQuery(@QueryParam("type") String type,@QueryParam("name") String name)
{
	if(type!=null&& name!=null)
	{
	System.out.println(type+" "+name);
	return "<result><status>success</status></result>";
	}
	else
		return "<result><status>fail</status></result>";
    
}// how to send the data /webapi/info/query?type=movie&name=vhh

@Path("/matrix")
@GET
@Produces(MediaType.APPLICATION_JSON)
public String insertMatrix(@MatrixParam("type") String type,@MatrixParam("name") String name)
{
	if(type!=null&& name!=null)
	{
	System.out.println(type+" "+name);
	return "{\"hello\",\"success\"}";
	}
	else
		return "{\"hello\",\"fail\"}";
}// how to send the data /webapi/st/matrix;type=movie;name=vhh


@Path("/form")
@POST
@Produces(MediaType.TEXT_HTML)
public String insertForm(@FormParam("type") String type,@FormParam("name") String name)
{
if(type!=null&& name!=null)
{
System.out.println(type+" "+name);
return "<html><body bgcolor='aqua'><p>Success</p></html>";
}
else
	return "<html><body bgcolor='aqua'><p>fail</p></html>";

}

}

