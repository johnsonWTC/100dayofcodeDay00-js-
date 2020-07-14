package day10.dayten;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class Hello {

    @RequestMapping("hello")
    public ModelAndView hello(@RequestParam(value = "name", defaultValue = "World")String name, @RequestParam(value = "surname", defaultValue = "dubula")String surname){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("name",name);
        modelAndView.addObject("surname",surname);
        modelAndView.setViewName("hello.jsp");
        return modelAndView;
    }

}
