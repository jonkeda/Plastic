import * as enumerations from  "Enumerations"

export class SsifRequest
{
    private _attest: SsifAttest[] = undefined;
    get attest():SsifAttest[] { return this._attest; }
    set attest(value: SsifAttest[]) { this._attest = value; }

    private _revoke: SsifRevoke[] = undefined;
    get revoke():SsifRevoke[] { return this._revoke; }
    set revoke(value: SsifRevoke[]) { this._revoke = value; }

    private _verifyRequest: SsifVerifyRequest[] = undefined;
    get verifyRequest():SsifVerifyRequest[] { return this._verifyRequest; }
    set verifyRequest(value: SsifVerifyRequest[]) { this._verifyRequest = value; }
}

export class SsifCreateRequestAnonymous
{
    private _ssifRequest: SsifRequest = undefined;
    get ssifRequest():SsifRequest { return this._ssifRequest; }
    set ssifRequest(value: SsifRequest) { this._ssifRequest = value; }
}

export class SsifCreateRequest
{
    private _ssifRequest: SsifRequest = undefined;
    get ssifRequest():SsifRequest { return this._ssifRequest; }
    set ssifRequest(value: SsifRequest) { this._ssifRequest = value; }

    private _publicExtendedKey: string = undefined;
    get publicExtendedKey():string { return this._publicExtendedKey; }
    set publicExtendedKey(value: string) { this._publicExtendedKey = value; }
}

export class SsifAttest
{
    private _iri: string = undefined;
    get iri():string { return this._iri; }
    set iri(value: string) { this._iri = value; }

    private _value: string = undefined;
    get value():string { return this._value; }
    set value(value: string) { this._value = value; }
}

export class SsifRevoke
{
    private _iri: string = undefined;
    get iri():string { return this._iri; }
    set iri(value: string) { this._iri = value; }
}

export class SsifVerifyRequest
{
    private _iri: string = undefined;
    get iri():string { return this._iri; }
    set iri(value: string) { this._iri = value; }

    private _value: string = undefined;
    get value():string { return this._value; }
    set value(value: string) { this._value = value; }

    private _trustedAttestor: SsifTrustedAttestor[] = undefined;
    get trustedAttestor():SsifTrustedAttestor[] { return this._trustedAttestor; }
    set trustedAttestor(value: SsifTrustedAttestor[]) { this._trustedAttestor = value; }
}

export class SsifTrustedAttestor
{
    private _type: enumerations.SsifTrustIssuerType = undefined;
    get type():enumerations.SsifTrustIssuerType { return this._type; }
    set type(value: enumerations.SsifTrustIssuerType) { this._type = value; }

    private _name: string = undefined;
    get name():string { return this._name; }
    set name(value: string) { this._name = value; }
}

export class SsifSessionRequest
{
    private _meta: SsifMeta = undefined;
    get meta():SsifMeta { return this._meta; }
    set meta(value: SsifMeta) { this._meta = value; }

    private _template: SsifSessionRequestTemplate = undefined;
    get template():SsifSessionRequestTemplate { return this._template; }
    set template(value: SsifSessionRequestTemplate) { this._template = value; }
}

export class SsifMeta
{
    private _attestationIssuer: SsifAttestationIssuerSpo = undefined;
    get attestationIssuer():SsifAttestationIssuerSpo { return this._attestationIssuer; }
    set attestationIssuer(value: SsifAttestationIssuerSpo) { this._attestationIssuer = value; }
}

export class SsifSpo
{
    private _context: string[] = undefined;
    get context():string[] { return this._context; }
    set context(value: string[]) { this._context = value; }

    private _type: string = undefined;
    get type():string { return this._type; }
    set type(value: string) { this._type = value; }

    private _statements: IriKeyValuePairs[] = undefined;
    get statements():IriKeyValuePairs[] { return this._statements; }
    set statements(value: IriKeyValuePairs[]) { this._statements = value; }

    private _commitment: SsifCommitment = undefined;
    get commitment():SsifCommitment { return this._commitment; }
    set commitment(value: SsifCommitment) { this._commitment = value; }
}

export class SsifCommitment
{
}

export class SsifAttestationIssuerSpo extends SsifSpo
{
}

export class IriKeyValuePairs
{
    private _iri: string = undefined;
    get iri():string { return this._iri; }
    set iri(value: string) { this._iri = value; }

    private _value: string = undefined;
    get value():string { return this._value; }
    set value(value: string) { this._value = value; }
}

export class SsifSessionRequestTemplate
{
    private _name: string = undefined;
    get name():string { return this._name; }
    set name(value: string) { this._name = value; }

    private _spo: SsifSpo = undefined;
    get spo():SsifSpo { return this._spo; }
    set spo(value: SsifSpo) { this._spo = value; }
}

export class SsifSessionResponse
{
    private _sessionId: string = undefined;
    get sessionId():string { return this._sessionId; }
    set sessionId(value: string) { this._sessionId = value; }

    private _attestations: SsifAttestation[] = undefined;
    get attestations():SsifAttestation[] { return this._attestations; }
    set attestations(value: SsifAttestation[]) { this._attestations = value; }
}

export class SsifAttestation
{
    private _name: string = undefined;
    get name():string { return this._name; }
    set name(value: string) { this._name = value; }

    private _spo: SsifAttestationSpo = undefined;
    get spo():SsifAttestationSpo { return this._spo; }
    set spo(value: SsifAttestationSpo) { this._spo = value; }
}

export class SsifAttestationSpo extends SsifSpo
{
}

export class SsifResult
{
    private _verifiedRequest: SsifSpo[] = undefined;
    get verifiedRequest():SsifSpo[] { return this._verifiedRequest; }
    set verifiedRequest(value: SsifSpo[]) { this._verifiedRequest = value; }

    private _revoked: SsifSpo[] = undefined;
    get revoked():SsifSpo[] { return this._revoked; }
    set revoked(value: SsifSpo[]) { this._revoked = value; }

    private _attested: SsifSpo[] = undefined;
    get attested():SsifSpo[] { return this._attested; }
    set attested(value: SsifSpo[]) { this._attested = value; }

    private _meta: SsifMeta = undefined;
    get meta():SsifMeta { return this._meta; }
    set meta(value: SsifMeta) { this._meta = value; }
}

export class SsifConfiguration
{
    private _blockchain: string = undefined;
    get blockchain():string { return this._blockchain; }
    set blockchain(value: string) { this._blockchain = value; }

    private _privateKey: string = undefined;
    get privateKey():string { return this._privateKey; }
    set privateKey(value: string) { this._privateKey = value; }

    private _categories: SsifCategory[] = undefined;
    get categories():SsifCategory[] { return this._categories; }
    set categories(value: SsifCategory[]) { this._categories = value; }

    private _attestors: SsifAttestor[] = undefined;
    get attestors():SsifAttestor[] { return this._attestors; }
    set attestors(value: SsifAttestor[]) { this._attestors = value; }

    private _requestPredicates: SsifPredicate[] = undefined;
    get requestPredicates():SsifPredicate[] { return this._requestPredicates; }
    set requestPredicates(value: SsifPredicate[]) { this._requestPredicates = value; }

    private _responsePredicates: SsifPredicate[] = undefined;
    get responsePredicates():SsifPredicate[] { return this._responsePredicates; }
    set responsePredicates(value: SsifPredicate[]) { this._responsePredicates = value; }
}

export class SsifAttestor
{
    private _name: string = undefined;
    get name():string { return this._name; }
    set name(value: string) { this._name = value; }

    private _ethereumAdress: string = undefined;
    get ethereumAdress():string { return this._ethereumAdress; }
    set ethereumAdress(value: string) { this._ethereumAdress = value; }

    private _logo: string = undefined;
    get logo():string { return this._logo; }
    set logo(value: string) { this._logo = value; }

    private _infoUrl: string = undefined;
    get infoUrl():string { return this._infoUrl; }
    set infoUrl(value: string) { this._infoUrl = value; }

    private _ssifUrl: string = undefined;
    get ssifUrl():string { return this._ssifUrl; }
    set ssifUrl(value: string) { this._ssifUrl = value; }

    private _texts: SsifText[] = undefined;
    get texts():SsifText[] { return this._texts; }
    set texts(value: SsifText[]) { this._texts = value; }
}

export class SsifPredicate
{
    private _iri: string = undefined;
    get iri():string { return this._iri; }
    set iri(value: string) { this._iri = value; }

    private _datatype: string = undefined;
    get datatype():string { return this._datatype; }
    set datatype(value: string) { this._datatype = value; }

    private _texts: SsifText[] = undefined;
    get texts():SsifText[] { return this._texts; }
    set texts(value: SsifText[]) { this._texts = value; }

    private _categoryName: string = undefined;
    get categoryName():string { return this._categoryName; }
    set categoryName(value: string) { this._categoryName = value; }

    private _attestorNames: string[] = undefined;
    get attestorNames():string[] { return this._attestorNames; }
    set attestorNames(value: string[]) { this._attestorNames = value; }
}

export class SsifText
{
    private _langcode: string = undefined;
    get langcode():string { return this._langcode; }
    set langcode(value: string) { this._langcode = value; }

    private _text: string = undefined;
    get text():string { return this._text; }
    set text(value: string) { this._text = value; }
}

export class SsifCategory
{
    private _name: string = undefined;
    get name():string { return this._name; }
    set name(value: string) { this._name = value; }

    private _texts: SsifText[] = undefined;
    get texts():SsifText[] { return this._texts; }
    set texts(value: SsifText[]) { this._texts = value; }
}

export class SsifAttestorInformation
{
    private _name: string = undefined;
    get name():string { return this._name; }
    set name(value: string) { this._name = value; }

    private _ethereumAdress: string = undefined;
    get ethereumAdress():string { return this._ethereumAdress; }
    set ethereumAdress(value: string) { this._ethereumAdress = value; }

    private _logo: string = undefined;
    get logo():string { return this._logo; }
    set logo(value: string) { this._logo = value; }

    private _infoUrl: string = undefined;
    get infoUrl():string { return this._infoUrl; }
    set infoUrl(value: string) { this._infoUrl = value; }

    private _ssifUrl: string = undefined;
    get ssifUrl():string { return this._ssifUrl; }
    set ssifUrl(value: string) { this._ssifUrl = value; }

    private _texts: SsifText[] = undefined;
    get texts():SsifText[] { return this._texts; }
    set texts(value: SsifText[]) { this._texts = value; }

    private _responsePredicates: SsifPredicate[] = undefined;
    get responsePredicates():SsifPredicate[] { return this._responsePredicates; }
    set responsePredicates(value: SsifPredicate[]) { this._responsePredicates = value; }
}
