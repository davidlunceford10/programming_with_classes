using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Scripture

{

    public Scripture()
    {
        
    }

    public List<string> scripture = new List<string>
        {
            "40 For intelligence cleaveth unto intelligence; wisdom receiveth wisdom; truth embraceth truth; virtue loveth virtue; light cleaveth unto light; mercy hath compassion on mercy and claimeth her own; justice continueth its course and claimeth its own; judgment goeth before the face of him who sitteth upon the throne and governeth and executeth all things.\n41 He comprehendeth all things, and all things are before him, and all things are round about him; and he is above all things, and in all things, and is through all things, and is round about all things; and all things are by him, and of him, even God, forever and ever."
        };
         
         string firstString = scripture[0];

         string[] words = firstString.Split(' ');

         
         





}