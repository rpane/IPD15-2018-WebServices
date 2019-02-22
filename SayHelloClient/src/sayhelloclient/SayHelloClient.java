/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sayhelloclient;

import org.tempuri.ArrayOfSayHello;
import org.tempuri.SayHello;

/**
 *
 * @author 0639300
 */
public class SayHelloClient {

    static org.tempuri.SayHelloWS service = new org.tempuri.SayHelloWS();
    static org.tempuri.SayHelloWSSoap port = service.getSayHelloWSSoap();
        
    public static void main(String[] args) {      
        System.out.println(sayHelloString("Roberto","Panetta"));
        System.out.println(sayHelloJson("Roberto", "Panetta"));   
        System.out.printf("%s %s \n",port.sayHelloObject("Roberto","Panetta").getGreeting(),port.sayHelloObject("Roberto", "Panetta").getName());
        
        ArrayOfSayHello sayHello = port.sayAllHelloObjects("Roberto", "Panetta");
        sayHello.getSayHello().forEach(item -> System.out.printf("%s %s \n",item.getGreeting(), item.getName()));
      
    }

    private static String sayHelloString(java.lang.String firstName, java.lang.String lastName) {        
        return port.sayHelloString(firstName, lastName);
    }

    private static String sayHelloJson(java.lang.String firstName, java.lang.String lastName) {       
        return port.sayHelloJson(firstName, lastName);
    }

    private static SayHello sayHelloObject(java.lang.String firstName, java.lang.String lastName) {        
        return port.sayHelloObject(firstName, lastName);
    }

    private static ArrayOfSayHello sayAllHelloObjects(java.lang.String firstName, java.lang.String lastName) {       
        return port.sayAllHelloObjects(firstName, lastName);
    }

    
}
