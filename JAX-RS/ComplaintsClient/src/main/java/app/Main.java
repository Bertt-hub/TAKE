/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import javax.ws.rs.client.Client;
import javax.ws.rs.client.ClientBuilder;
import javax.ws.rs.core.MediaType;
import com.google.gson.Gson;
import java.util.logging.Level;
import java.util.logging.Logger;
import static javax.ws.rs.client.Entity.entity;

/**
 *
 * @author Hubert
 * 
 * Sources
 *   https://www.java67.com/2016/10/3-ways-to-convert-string-to-json-object-in-java.html
 *   https://www.logicbig.com/tutorials/java-ee-tutorial/jax-rs/put-example.html
 *   https://www.tutorialspoint.com/how-to-convert-java-object-to-json-using-jackson-library
 */
public class Main {

    public static void main(String[] args) throws Exception {
        Client client = ClientBuilder.newClient();

        String complaintsAll = getAllComplaints(client);

        System.out.println("All complaints: " + complaintsAll);

        String complaintsOpen = getOpenComplaints(client);
        
        System.out.println("All open complaints before change: " + complaintsOpen);

        
        Integer firstOpenComplaintId = getFirstComplaintId(complaintsOpen);
        String firstOpenComplaint;

        if (firstOpenComplaintId != null) {
            
            firstOpenComplaint = getComplaintById(client, firstOpenComplaintId);
            System.out.println("First open complaint: " + firstOpenComplaint);
            
            Complaint complaintObjectChanged = changeComplaintObjectStatus(firstOpenComplaint, "closed");
            
            ObjectMapper mapper = new ObjectMapper();
            String jsonComplaintChanged = mapper.writeValueAsString(complaintObjectChanged);
            changeComplaint(client, firstOpenComplaintId, jsonComplaintChanged);
            System.out.println("Complaint with id: " + firstOpenComplaintId.toString() + " status changed to \"closed\"");
            
            String complaintsOpenAfter = getOpenComplaints(client);
            System.out.println("All open complaints after change: " + complaintsOpenAfter);
            
        } else {
            System.out.println("There are no open complaints");
        }

        client.close();

    }

    public static String getAllComplaints(Client client){
        return client.target("http://localhost:8080/Complaints/resources/complaints")
                .request(MediaType.APPLICATION_JSON)
                .get(String.class);
    }
    
    public static String getOpenComplaints(Client client){
        return client.target("http://localhost:8080/Complaints/resources/complaints?status=open")
                .request(MediaType.APPLICATION_JSON)
                .get(String.class);
    }
    
    public static String getComplaintById(Client client, Integer id){
        return client.target("http://localhost:8080/Complaints/resources/complaints/" + id.toString())
                    .request(MediaType.APPLICATION_JSON)
                    .get(String.class);
    }
    
    public static void changeComplaint(Client client, Integer complaintId, String json){
        client.target("http://localhost:8080/Complaints/resources/complaints/" + complaintId.toString())
                    .request()
                    .put(entity(json, MediaType.APPLICATION_JSON));
    }

    public static Integer getFirstComplaintId(String openComplaints) {
        Gson g = new Gson();
        Complaint[] complaint = g.fromJson(openComplaints, Complaint[].class);

        return complaint[0].getId();
    }

    public static Complaint changeComplaintObjectStatus(String singleComplaint, String status) {
        Gson g = new Gson();
        Complaint complaint = g.fromJson(singleComplaint, Complaint.class);
        complaint.setStatus(status);
        
        return complaint;
    }

}
