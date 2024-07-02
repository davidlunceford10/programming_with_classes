class Fireman : Person //this is how you reference inheritance.
{
private string _certifications;
public Fireman(string certifications, string f, string l, int a, int w) : base(f,l,a,w)
{
_certifications = certifications;
}

public string FiremanInformation()
{
    return $"{_certifications}, {PersonInformation()}";
}

}
    