// (Mr\.|Mrs\.|Ms\.|Dr\.|Er\.) Word must start with either one
// . Match any characters except line breaks
// * Match 0 or more after this
// [a-zA-Z] any letters in the alphabet upper or lowercase
// $ ends with the preceding arguments [a-zA-Z]
// /g globally match
// m multiline match   
const re = new RegExp(/(Mr\.|Mrs\.|Ms\.|Dr\.|Er\.).*[a-zA-Z]$/gm);


/*
 * Do not remove the return statement
 */
return re;