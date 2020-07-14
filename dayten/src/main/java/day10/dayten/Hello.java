package day10.dayten;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class Hello {

    @GetMapping("/hello")
    public ModelAndView hello(@RequestParam("name"), String name){
        ModelAndView modelAndView = new ModelAndView();

        return modelAndView.getView()
    }
}
