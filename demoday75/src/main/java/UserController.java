import com.example.demoday75.User;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

public class UserController {
    @RestController
    @RequestMapping("users")

    @PostMapping("create")
    public User createUser(User user){

    }
}
