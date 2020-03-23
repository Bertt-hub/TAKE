/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Hubert
 */
public class Student {
    private String Name;
    private String LastName;
    private Double Average;

    
    public Student(String Name, String LastName, Double Average) {
        this.Name = Name;
        this.LastName = LastName;
        this.Average = Average;
    }
    /**
     * @return the Name
     */
    public String getName() {
        return Name;
    }

    /**
     * @param Name the Name to set
     */
    public void setName(String Name) {
        this.Name = Name;
    }

    /**
     * @return the LastName
     */
    public String getLastName() {
        return LastName;
    }

    /**
     * @param LastName the LastName to set
     */
    public void setLastName(String LastName) {
        this.LastName = LastName;
    }

    /**
     * @return the Average
     */
    public Double getAverage() {
        return Average;
    }

    /**
     * @param Average the Average to set
     */
    public void setAverage(Double Average) {
        this.Average = Average;
    }
    
}
