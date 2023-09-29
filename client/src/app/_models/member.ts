import { Photo } from "./photo";

export interface Member {
    userId: number;
    userName: string;
    photoUrl: string;
    age: number;
    knownAs: string;
    gender: string;
    introduction: string;
    lookingFor: string;
    interests: string;
    city: string;
    country: string;
    photos: Photo[];
    createdOn: Date;
    lastActive: Date;
}


