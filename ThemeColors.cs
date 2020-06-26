namespace ProgramForms
{
    public class ThemeColors
    {

    public static string colorList(string nameBtn)
        {
            switch (nameBtn)
            {
                case "btnHome":
                    return "#a90f17";
                case "btnCal":
                    return "#479565";
                case "btnSto":
                    return "#661bb1";
                case "btnWea":
                    return "#186ff2";
                case "btnNot":
                    return "#ffb300";
                case "btnDB":
                    return "#4dbeff";
                case "btnInf":
                    return "#171717";
                default:
                    return "a90f17";
            }
        }
    }
}
