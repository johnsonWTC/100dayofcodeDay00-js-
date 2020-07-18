package day10.dayten;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class profile {
    @RequestMapping("profile")
    public ModelAndView profile(@RequestParam(value = "names",defaultValue = "please insert name") String amagama){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("igama",amagama);
        modelAndView.setViewName("profile.jsp");
        return modelAndView;
    }
}
