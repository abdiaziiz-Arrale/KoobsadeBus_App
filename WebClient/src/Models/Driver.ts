

export interface Driver{
      id: number ;
      DriverLiceince : string ;
      TypeOfBus:string ;
      CarTrNo: string ;
      NumberOfseats: number ;
      user?: User ;


}

export interface User{
      Fullname: string ;
      Address: string ;
      gender: string ;
} 