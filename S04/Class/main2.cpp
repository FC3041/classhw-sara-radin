class date
{
    int day;
    int month;
    int year;
};


class person
{
    int m_nid;
    char m_fname[20];
    char m_lname[20];
    date m_bd;

    public:
     person(const char * fname , const char * lanme , int id ,date bd)
     :m_bd(bd), m_nid(id)
     {
        int i;
        for (i=0;i<sizeof(m_fname) && fname[i]!= '0';i++)
        {
              
        }
        
        
        
     }


    ~person()
    {

    }
};