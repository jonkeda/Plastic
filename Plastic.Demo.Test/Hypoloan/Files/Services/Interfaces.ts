import * as enumerations from  "../Models/Enumerations"
import * as models from  "../Models/Models"
export interface SsifWebSite
{
    ssifRequest(request: models.SsifRequest): boolean
    ssifCreateSessionId(): string
    callbackSession(sessionId: string): models.SsifResult
    getSessionRequest(sessionId: string): models.SsifSessionRequest
    postSessionResponse(response: models.SsifSessionResponse): boolean
}
export interface SsifApi
{
    createSessionRequestAnonymous(request: models.SsifCreateRequestAnonymous): models.SsifSessionRequest
    createSessionRequest(request: models.SsifCreateRequest): models.SsifSessionRequest
    verifySession(request: models.SsifSessionRequest    , 
    response: models.SsifSessionResponse): boolean
    getSsifAttestorInformation(): models.SsifAttestorInformation
}
