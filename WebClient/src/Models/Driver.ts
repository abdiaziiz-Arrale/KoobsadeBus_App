

export interface Driver{
      id: number ;
      DriverLiceince : string ;
      typeOfBus:string ;
      CarTrNo: string ;
      numberOfseats: number ;
      user: User ;


}

export interface User{
      fullName: string ;
      Address: string ;
      gender: string ;
} 