/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package view.backing;

import java.util.ResourceBundle;
import javax.inject.Named;
import javax.enterprise.context.RequestScoped;
import javax.faces.application.FacesMessage;
import javax.faces.component.html.HtmlCommandButton;
import javax.faces.component.html.HtmlSelectBooleanCheckbox;
import javax.faces.context.FacesContext;
import javax.faces.event.ValueChangeEvent;

/**
 *
 * @author Hubert
 */
@Named(value = "loginBean")
@RequestScoped
public class LoginBean {
    private String username;
    private String password;
    private HtmlSelectBooleanCheckbox acceptCheckbox;
    private HtmlCommandButton loginButton; 
    /**
     * Creates a new instance of LoginBean
     */
    public LoginBean() {
    }

    /**
     * @return the username
     */
    public String getUsername() {
        return username;
    }

    /**
     * @param username the username to set
     */
    public void setUsername(String username) {
        this.username = username;
    }

    /**
     * @return the password
     */
    public String getPassword() {
        return password;
    }

    /**
     * @param password the password to set
     */
    public void setPassword(String password) {
        this.password = password;
    }
    
    /**
     * https://stackoverflow.com/questions/13655540/read-resource-bundle-properties-in-a-managed-bean/13656194#13656194 - ResourceBundle
     * https://stackoverflow.com/questions/2313454/jsf-message-severity - FacesMessage
     * @return
     */
    public String login(){
        if (username.equals(password)) {
            return "success";
        } else {
            if (username.equals("scott") && password.equals("tiger")){
                FacesContext context = FacesContext.getCurrentInstance();
                ResourceBundle resourceBundle = ResourceBundle.getBundle("ApplicationMessages", context.getViewRoot().getLocale());
                FacesMessage errorMessage = new FacesMessage(resourceBundle.getString("validation.oracle"));
                errorMessage.setSeverity(FacesMessage.SEVERITY_ERROR);
                context.addMessage(null, errorMessage);
                context.renderResponse(); 
                return null;
            } else {
                return "failure";
            }
            
        }
    }
    /**
     * @return the acceptCheckbox
     */
    public HtmlSelectBooleanCheckbox getAcceptCheckbox() {
        return acceptCheckbox;
    }

    /**
     * @param acceptCheckbox the acceptCheckbox to set
     */
    public void setAcceptCheckbox(HtmlSelectBooleanCheckbox acceptCheckbox) {
        this.acceptCheckbox = acceptCheckbox;
    }

    /**
     * @return the loginButton
     */
    public HtmlCommandButton getLoginButton() {
        return loginButton;
    }

    /**
     * @param loginButton the loginButton to set
     */
    public void setLoginButton(HtmlCommandButton loginButton) {
        this.loginButton = loginButton;
    }
    
    public void activateButton(ValueChangeEvent e)
    {
    if (acceptCheckbox.isSelected())
        loginButton.setDisabled(false);
    else
        loginButton.setDisabled(true);
    FacesContext context = FacesContext.getCurrentInstance();
    context.renderResponse(); 
    }


    
}
