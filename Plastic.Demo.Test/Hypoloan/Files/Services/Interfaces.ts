import * as enumerations from  "../Models/Enumerations"
import * as models from  "../Models/Models"
export interface SsifWebSite
{
    ssifRequest(request: models.SsifRequest): Boolean
    ssifCreateSessionId(): String
    callbackSession(sessionId: String): models.SsifResult
    getSessionRequest(sessionId: String): models.SsifSessionRequest
    postSessionResponse(response: models.SsifSessionResponse): Boolean
}
export interface SsifApi
{
    createSessionRequestAnonymous(request: models.SsifCreateRequestAnonymous): models.SsifSessionRequest
    createSessionRequest(request: models.SsifCreateRequest): models.SsifSessionRequest
    verifySession(request: models.SsifSessionRequest    , 
    response: models.SsifSessionResponse): Boolean
    getSsifAttestorInformation(): models.SsifAttestorInformation
}
