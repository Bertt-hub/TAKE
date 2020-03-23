/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import javax.inject.Named;
import javax.enterprise.context.RequestScoped;
import javax.inject.Inject;
import org.primefaces.model.chart.Axis;
import org.primefaces.model.chart.AxisType;
import org.primefaces.model.chart.CategoryAxis;
import org.primefaces.model.chart.ChartSeries;
import org.primefaces.model.chart.LineChartModel;

/**
 *
 * @author Hubert
 */
@Named(value = "primeFaces")
@RequestScoped
public class PrimeFaces {
    private int number1;
    private int number2;
    private int result;
    private List<Student> students;
    private LineChartModel lineModel;
    
   
    
    
    /**
     * Creates a new instance of PrimeFaces
     */
    public PrimeFaces() {
       List<Student> list = new ArrayList<Student>();
       list.add(new Student("Adam","Kuczyński",5.00));
       list.add(new Student("Ada","Konopko",3.52));
       list.add(new Student("Maciej","Pękala",4.44));
       list.add(new Student("Agata","Kępińska",3.75));
       list.add(new Student("Maciej","Perek",4.98));
       list.add(new Student("Tomasz","Jurecki",2.40));
       list.add(new Student("Bartosz","Brzozowski",4.91));
       list.add(new Student("Karolina","Kopycińska",3.98));
       list.add(new Student("Magda","Abramowicz",4.55));
       list.add(new Student("Sylwia","Cicha",5.00));
       list.add(new Student("Adam","Abramowicz",4.55));
       list.add(new Student("Agata","Cicha",5.00));
       list.add(new Student("Adam","Jurecki",2.40));
       list.add(new Student("Maciej","Brzozowski",4.91));
       list.add(new Student("Karolina","Kopycińska",3.98));
       
       this.students = list;
       
       GenerateLineChart();
    }
    
    private void GenerateLineChart(){
        lineModel = new LineChartModel();
        lineModel.setTitle("Line Chart of Sine and Cosine [0 - 2π]");
        lineModel.setLegendPosition("ne");
        lineModel.setShowPointLabels(true);
        Axis yAxis = lineModel.getAxis(AxisType.Y);
        yAxis.setMin(-1.5);
        yAxis.setMax(1.5);
        lineModel.getAxes().put(AxisType.X, new CategoryAxis("degrees [°]"));
        
        
        ChartSeries sine = new ChartSeries();
        ChartSeries cosine = new ChartSeries();
        
        lineModel.setSeriesColors("FF0000,FFFF00");
        sine.setLabel("Sine");
        cosine.setLabel("Cosine");
        
        for (int i=0; i<=360; i+=10) {
            sine.set(i, Math.sin(i));
            cosine.set(i, Math.cos(i));
        }
        
        lineModel.addSeries(cosine);
        lineModel.addSeries(sine);
        
        lineModel.setZoom(true);
    }

    /**
     * @return the number1
     */
    public int getNumber1() {
        return number1;
    }

    /**
     * @param number1 the number1 to set
     */
    public void setNumber1(int number1) {
        this.number1 = number1;
    }

    /**
     * @return the number2
     */
    public int getNumber2() {
        return number2;
    }

    /**
     * @param number2 the number2 to set
     */
    public void setNumber2(int number2) {
        this.number2 = number2;
    }

    /**
     * @return the result
     */
    public int getResult() {
        return result;
    }

    /**
     * @param result the result to set
     */
    public void setResult(int result) {
        this.result = result;
    }
    
    public int Calculate(){
        result = number1 + number2;  
        return result;
    }
    
    public String getDate(){
        return new java.util.Date().toString();
    }

    /**
     * @return the students
     */
    public List<Student> getStudents() {
        return students;
    }

    /**
     * @param students the students to set
     */
    public void setStudents(List<Student> students) {
        this.students = students;
    }

    /**
     * @return the lineModel
     */
    public LineChartModel getLineModel() {
        return lineModel;
    }

    /**
     * @param lineModel the lineModel to set
     */
    public void setLineModel(LineChartModel lineModel) {
        this.lineModel = lineModel;
    }




   
}
