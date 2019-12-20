namespace Kotesek.Sealed
{
    class SealedClassB
    {

        //itt már nem lehet overrideolni az ősosztály metódusát, mert sealed...
        //public override int GetValueKesoi()
        //{
        //    return 0;
        //}

        // ez pedig értelmetlen, mert ha valamit megjegyzünk, hogy késői kötés lesz és le is zárjuk. Ez a kettő üti egymást.
        //public virtual sealed int Ostobasag()
        //{
        //    return 0;
        //}

    }
}
