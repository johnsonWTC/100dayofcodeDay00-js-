package day10.dayten;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class welcome {
    @GetMapping("welcome")
    public ModelAndView hello(@RequestParam(value = "name", defaultValue = "World")String MyName){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("name",MyName);
        modelAndView.setViewName("welcome.jsp");
        return modelAndView;
    }
}
