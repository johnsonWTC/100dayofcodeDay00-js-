package day10.dayten;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class Hello {

    @GetMapping("hello")
    public ModelAndView hello(@RequestParam(value = "name", defaultValue = "World")String name){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("name",name);
        modelAndView.setViewName("hello.jsp");
        return modelAndView;
    }

}
