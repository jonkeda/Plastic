import { JsonObject, JsonProperty } from "json2typescript";
import * as enumerations from  "./Enumerations";

export class IriKeyValuePairs
{
    @JsonProperty("iri", String)
    private _iri: String = undefined;
    get iri():String { return this._iri; }
    set iri(value: String) { this._iri = value; }

    @JsonProperty("value", String)
    private _value: String = undefined;
    get value():String { return this._value; }
    set value(value: String) { this._value = value; }
}

export class SsifCommitment
{
}

export class SsifSpo
{
    @JsonProperty("context", [String])
    private _context: String[] = undefined;
    get context():String[] { return this._context; }
    set context(value: String[]) { this._context = value; }

    @JsonProperty("type", String)
    private _type: String = undefined;
    get type():String { return this._type; }
    set type(value: String) { this._type = value; }

    @JsonProperty("statements", [IriKeyValuePairs])
    private _statements: IriKeyValuePairs[] = undefined;
    get statements():IriKeyValuePairs[] { return this._statements; }
    set statements(value: IriKeyValuePairs[]) { this._statements = value; }

    @JsonProperty("commitment", SsifCommitment)
    private _commitment: SsifCommitment = undefined;
    get commitment():SsifCommitment { return this._commitment; }
    set commitment(value: SsifCommitment) { this._commitment = value; }
}

export class SsifTrustedAttestor
{
    @JsonProperty("type", enumerations.SsifTrustIssuerType)
    private _type: enumerations.SsifTrustIssuerType = undefined;
    get type():enumerations.SsifTrustIssuerType { return this._type; }
    set type(value: enumerations.SsifTrustIssuerType) { this._type = value; }

    @JsonProperty("name", String)
    private _name: String = undefined;
    get name():String { return this._name; }
    set name(value: String) { this._name = value; }
}

export class SsifAttest
{
    @JsonProperty("iri", String)
    private _iri: String = undefined;
    get iri():String { return this._iri; }
    set iri(value: String) { this._iri = value; }

    @JsonProperty("value", String)
    private _value: String = undefined;
    get value():String { return this._value; }
    set value(value: String) { this._value = value; }
}

export class SsifAttestationIssuerSpo extends SsifSpo
{
}

export class SsifAttestationSpo extends SsifSpo
{
}

export class SsifRevoke
{
    @JsonProperty("iri", String)
    private _iri: String = undefined;
    get iri():String { return this._iri; }
    set iri(value: String) { this._iri = value; }
}

export class SsifText
{
    @JsonProperty("langcode", String)
    private _langcode: String = undefined;
    get langcode():String { return this._langcode; }
    set langcode(value: String) { this._langcode = value; }

    @JsonProperty("text", String)
    private _text: String = undefined;
    get text():String { return this._text; }
    set text(value: String) { this._text = value; }
}

export class SsifVerifyRequest
{
    @JsonProperty("iri", String)
    private _iri: String = undefined;
    get iri():String { return this._iri; }
    set iri(value: String) { this._iri = value; }

    @JsonProperty("value", String)
    private _value: String = undefined;
    get value():String { return this._value; }
    set value(value: String) { this._value = value; }

    @JsonProperty("trustedAttestor", [SsifTrustedAttestor])
    private _trustedAttestor: SsifTrustedAttestor[] = undefined;
    get trustedAttestor():SsifTrustedAttestor[] { return this._trustedAttestor; }
    set trustedAttestor(value: SsifTrustedAttestor[]) { this._trustedAttestor = value; }
}

export class SsifAttestation
{
    @JsonProperty("name", String)
    private _name: String = undefined;
    get name():String { return this._name; }
    set name(value: String) { this._name = value; }

    @JsonProperty("spo", SsifAttestationSpo)
    private _spo: SsifAttestationSpo = undefined;
    get spo():SsifAttestationSpo { return this._spo; }
    set spo(value: SsifAttestationSpo) { this._spo = value; }
}

export class SsifAttestor
{
    @JsonProperty("name", String)
    private _name: String = undefined;
    get name():String { return this._name; }
    set name(value: String) { this._name = value; }

    @JsonProperty("ethereumAdress", String)
    private _ethereumAdress: String = undefined;
    get ethereumAdress():String { return this._ethereumAdress; }
    set ethereumAdress(value: String) { this._ethereumAdress = value; }

    @JsonProperty("logo", String)
    private _logo: String = undefined;
    get logo():String { return this._logo; }
    set logo(value: String) { this._logo = value; }

    @JsonProperty("infoUrl", String)
    private _infoUrl: String = undefined;
    get infoUrl():String { return this._infoUrl; }
    set infoUrl(value: String) { this._infoUrl = value; }

    @JsonProperty("ssifUrl", String)
    private _ssifUrl: String = undefined;
    get ssifUrl():String { return this._ssifUrl; }
    set ssifUrl(value: String) { this._ssifUrl = value; }

    @JsonProperty("texts", [SsifText])
    private _texts: SsifText[] = undefined;
    get texts():SsifText[] { return this._texts; }
    set texts(value: SsifText[]) { this._texts = value; }
}

export class SsifCategory
{
    @JsonProperty("name", String)
    private _name: String = undefined;
    get name():String { return this._name; }
    set name(value: String) { this._name = value; }

    @JsonProperty("texts", [SsifText])
    private _texts: SsifText[] = undefined;
    get texts():SsifText[] { return this._texts; }
    set texts(value: SsifText[]) { this._texts = value; }
}

export class SsifMeta
{
    @JsonProperty("attestationIssuer", SsifAttestationIssuerSpo)
    private _attestationIssuer: SsifAttestationIssuerSpo = undefined;
    get attestationIssuer():SsifAttestationIssuerSpo { return this._attestationIssuer; }
    set attestationIssuer(value: SsifAttestationIssuerSpo) { this._attestationIssuer = value; }
}

export class SsifPredicate
{
    @JsonProperty("iri", String)
    private _iri: String = undefined;
    get iri():String { return this._iri; }
    set iri(value: String) { this._iri = value; }

    @JsonProperty("datatype", String)
    private _datatype: String = undefined;
    get datatype():String { return this._datatype; }
    set datatype(value: String) { this._datatype = value; }

    @JsonProperty("texts", [SsifText])
    private _texts: SsifText[] = undefined;
    get texts():SsifText[] { return this._texts; }
    set texts(value: SsifText[]) { this._texts = value; }

    @JsonProperty("categoryName", String)
    private _categoryName: String = undefined;
    get categoryName():String { return this._categoryName; }
    set categoryName(value: String) { this._categoryName = value; }

    @JsonProperty("attestorNames", [String])
    private _attestorNames: String[] = undefined;
    get attestorNames():String[] { return this._attestorNames; }
    set attestorNames(value: String[]) { this._attestorNames = value; }
}

export class SsifRequest
{
    @JsonProperty("attest", [SsifAttest])
    private _attest: SsifAttest[] = undefined;
    get attest():SsifAttest[] { return this._attest; }
    set attest(value: SsifAttest[]) { this._attest = value; }

    @JsonProperty("revoke", [SsifRevoke])
    private _revoke: SsifRevoke[] = undefined;
    get revoke():SsifRevoke[] { return this._revoke; }
    set revoke(value: SsifRevoke[]) { this._revoke = value; }

    @JsonProperty("verifyRequest", [SsifVerifyRequest])
    private _verifyRequest: SsifVerifyRequest[] = undefined;
    get verifyRequest():SsifVerifyRequest[] { return this._verifyRequest; }
    set verifyRequest(value: SsifVerifyRequest[]) { this._verifyRequest = value; }
}

export class SsifSessionRequestTemplate
{
    @JsonProperty("name", String)
    private _name: String = undefined;
    get name():String { return this._name; }
    set name(value: String) { this._name = value; }

    @JsonProperty("spo", SsifSpo)
    private _spo: SsifSpo = undefined;
    get spo():SsifSpo { return this._spo; }
    set spo(value: SsifSpo) { this._spo = value; }
}

export class SsifAttestorInformation
{
    @JsonProperty("name", String)
    private _name: String = undefined;
    get name():String { return this._name; }
    set name(value: String) { this._name = value; }

    @JsonProperty("ethereumAdress", String)
    private _ethereumAdress: String = undefined;
    get ethereumAdress():String { return this._ethereumAdress; }
    set ethereumAdress(value: String) { this._ethereumAdress = value; }

    @JsonProperty("logo", String)
    private _logo: String = undefined;
    get logo():String { return this._logo; }
    set logo(value: String) { this._logo = value; }

    @JsonProperty("infoUrl", String)
    private _infoUrl: String = undefined;
    get infoUrl():String { return this._infoUrl; }
    set infoUrl(value: String) { this._infoUrl = value; }

    @JsonProperty("ssifUrl", String)
    private _ssifUrl: String = undefined;
    get ssifUrl():String { return this._ssifUrl; }
    set ssifUrl(value: String) { this._ssifUrl = value; }

    @JsonProperty("texts", [SsifText])
    private _texts: SsifText[] = undefined;
    get texts():SsifText[] { return this._texts; }
    set texts(value: SsifText[]) { this._texts = value; }

    @JsonProperty("responsePredicates", [SsifPredicate])
    private _responsePredicates: SsifPredicate[] = undefined;
    get responsePredicates():SsifPredicate[] { return this._responsePredicates; }
    set responsePredicates(value: SsifPredicate[]) { this._responsePredicates = value; }
}

export class SsifConfiguration
{
    @JsonProperty("blockchain", String)
    private _blockchain: String = undefined;
    get blockchain():String { return this._blockchain; }
    set blockchain(value: String) { this._blockchain = value; }

    @JsonProperty("privateKey", String)
    private _privateKey: String = undefined;
    get privateKey():String { return this._privateKey; }
    set privateKey(value: String) { this._privateKey = value; }

    @JsonProperty("categories", [SsifCategory])
    private _categories: SsifCategory[] = undefined;
    get categories():SsifCategory[] { return this._categories; }
    set categories(value: SsifCategory[]) { this._categories = value; }

    @JsonProperty("attestors", [SsifAttestor])
    private _attestors: SsifAttestor[] = undefined;
    get attestors():SsifAttestor[] { return this._attestors; }
    set attestors(value: SsifAttestor[]) { this._attestors = value; }

    @JsonProperty("requestPredicates", [SsifPredicate])
    private _requestPredicates: SsifPredicate[] = undefined;
    get requestPredicates():SsifPredicate[] { return this._requestPredicates; }
    set requestPredicates(value: SsifPredicate[]) { this._requestPredicates = value; }

    @JsonProperty("responsePredicates", [SsifPredicate])
    private _responsePredicates: SsifPredicate[] = undefined;
    get responsePredicates():SsifPredicate[] { return this._responsePredicates; }
    set responsePredicates(value: SsifPredicate[]) { this._responsePredicates = value; }
}

export class SsifCreateRequest
{
    @JsonProperty("ssifRequest", SsifRequest)
    private _ssifRequest: SsifRequest = undefined;
    get ssifRequest():SsifRequest { return this._ssifRequest; }
    set ssifRequest(value: SsifRequest) { this._ssifRequest = value; }

    @JsonProperty("publicExtendedKey", String)
    private _publicExtendedKey: String = undefined;
    get publicExtendedKey():String { return this._publicExtendedKey; }
    set publicExtendedKey(value: String) { this._publicExtendedKey = value; }
}

export class SsifCreateRequestAnonymous
{
    @JsonProperty("ssifRequest", SsifRequest)
    private _ssifRequest: SsifRequest = undefined;
    get ssifRequest():SsifRequest { return this._ssifRequest; }
    set ssifRequest(value: SsifRequest) { this._ssifRequest = value; }
}

export class SsifResult
{
    @JsonProperty("verifiedRequest", [SsifSpo])
    private _verifiedRequest: SsifSpo[] = undefined;
    get verifiedRequest():SsifSpo[] { return this._verifiedRequest; }
    set verifiedRequest(value: SsifSpo[]) { this._verifiedRequest = value; }

    @JsonProperty("revoked", [SsifSpo])
    private _revoked: SsifSpo[] = undefined;
    get revoked():SsifSpo[] { return this._revoked; }
    set revoked(value: SsifSpo[]) { this._revoked = value; }

    @JsonProperty("attested", [SsifSpo])
    private _attested: SsifSpo[] = undefined;
    get attested():SsifSpo[] { return this._attested; }
    set attested(value: SsifSpo[]) { this._attested = value; }

    @JsonProperty("meta", SsifMeta)
    private _meta: SsifMeta = undefined;
    get meta():SsifMeta { return this._meta; }
    set meta(value: SsifMeta) { this._meta = value; }
}

export class SsifSessionRequest
{
    @JsonProperty("meta", SsifMeta)
    private _meta: SsifMeta = undefined;
    get meta():SsifMeta { return this._meta; }
    set meta(value: SsifMeta) { this._meta = value; }

    @JsonProperty("template", SsifSessionRequestTemplate)
    private _template: SsifSessionRequestTemplate = undefined;
    get template():SsifSessionRequestTemplate { return this._template; }
    set template(value: SsifSessionRequestTemplate) { this._template = value; }
}

export class SsifSessionResponse
{
    @JsonProperty("sessionId", String)
    private _sessionId: String = undefined;
    get sessionId():String { return this._sessionId; }
    set sessionId(value: String) { this._sessionId = value; }

    @JsonProperty("attestations", [SsifAttestation])
    private _attestations: SsifAttestation[] = undefined;
    get attestations():SsifAttestation[] { return this._attestations; }
    set attestations(value: SsifAttestation[]) { this._attestations = value; }
}
