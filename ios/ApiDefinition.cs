﻿using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace DBRiOS
{
    // @interface iFurtherModes : NSObject
    [BaseType(typeof(NSObject))]
    interface iFurtherModes
    {
        // @property (readwrite, nonatomic) NSArray * _Nullable colourClusteringModes;
        [NullAllowed, Export("colourClusteringModes", ArgumentSemantic.Assign)]

        NSObject[] ColourClusteringModes { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable colourConversionModes;
        [NullAllowed, Export("colourConversionModes", ArgumentSemantic.Assign)]

        NSObject[] ColourConversionModes { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable grayscaleTransformationModes;
        [NullAllowed, Export("grayscaleTransformationModes", ArgumentSemantic.Assign)]

        NSObject[] GrayscaleTransformationModes { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable regionPredetectionModes;
        [NullAllowed, Export("regionPredetectionModes", ArgumentSemantic.Assign)]

        NSObject[] RegionPredetectionModes { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable imagePreprocessingModes;
        [NullAllowed, Export("imagePreprocessingModes", ArgumentSemantic.Assign)]

        NSObject[] ImagePreprocessingModes { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable textureDetectionModes;
        [NullAllowed, Export("textureDetectionModes", ArgumentSemantic.Assign)]

        NSObject[] TextureDetectionModes { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable textFilterModes;
        [NullAllowed, Export("textFilterModes", ArgumentSemantic.Assign)]

        NSObject[] TextFilterModes { get; set; }

        // @property (assign, nonatomic) EnumTextAssistedCorrectionMode textAssistedCorrectionMode;
        [Export("textAssistedCorrectionMode", ArgumentSemantic.Assign)]
        EnumTextAssistedCorrectionMode TextAssistedCorrectionMode { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable dpmCodeReadingModes;
        [NullAllowed, Export("dpmCodeReadingModes", ArgumentSemantic.Assign)]

        NSObject[] DpmCodeReadingModes { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable deformationResistingModes;
        [NullAllowed, Export("deformationResistingModes", ArgumentSemantic.Assign)]

        NSObject[] DeformationResistingModes { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable barcodeComplementModes;
        [NullAllowed, Export("barcodeComplementModes", ArgumentSemantic.Assign)]

        NSObject[] BarcodeComplementModes { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable barcodeColourModes;
        [NullAllowed, Export("barcodeColourModes", ArgumentSemantic.Assign)]

        NSObject[] BarcodeColourModes { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable accompanyingTextRecognitionModes;
        [NullAllowed, Export("accompanyingTextRecognitionModes", ArgumentSemantic.Assign)]

        NSObject[] AccompanyingTextRecognitionModes { get; set; }
    }

    // @interface iRegionDefinition : NSObject
    [BaseType(typeof(NSObject))]
    interface iRegionDefinition
    {
        // @property (assign, nonatomic) NSInteger regionTop;
        [Export("regionTop")]
        nint RegionTop { get; set; }

        // @property (assign, nonatomic) NSInteger regionLeft;
        [Export("regionLeft")]
        nint RegionLeft { get; set; }

        // @property (assign, nonatomic) NSInteger regionRight;
        [Export("regionRight")]
        nint RegionRight { get; set; }

        // @property (assign, nonatomic) NSInteger regionBottom;
        [Export("regionBottom")]
        nint RegionBottom { get; set; }

        // @property (assign, nonatomic) NSInteger regionMeasuredByPercentage;
        [Export("regionMeasuredByPercentage")]
        nint RegionMeasuredByPercentage { get; set; }
    }

    // @interface iPublicRuntimeSettings : NSObject
    [BaseType(typeof(NSObject))]
    interface iPublicRuntimeSettings
    {
        // @property (assign, nonatomic) EnumTerminatePhase terminatePhase;
        [Export("terminatePhase", ArgumentSemantic.Assign)]
        EnumTerminatePhase TerminatePhase { get; set; }

        // @property (assign, nonatomic) NSInteger timeout;
        [Export("timeout")]
        nint Timeout { get; set; }

        // @property (assign, nonatomic) NSInteger maxAlgorithmThreadCount;
        [Export("maxAlgorithmThreadCount")]
        nint MaxAlgorithmThreadCount { get; set; }

        // @property (assign, nonatomic) NSInteger expectedBarcodesCount;
        [Export("expectedBarcodesCount")]
        nint ExpectedBarcodesCount { get; set; }

        // @property (assign, nonatomic) NSInteger barcodeFormatIds;
        [Export("barcodeFormatIds")]
        nint BarcodeFormatIds { get; set; }

        // @property (assign, nonatomic) NSInteger barcodeFormatIds_2;
        [Export("barcodeFormatIds_2")]
        nint BarcodeFormatIds_2 { get; set; }

        // @property (assign, nonatomic) NSInteger pdfRasterDPI;
        [Export("pdfRasterDPI")]
        nint PdfRasterDPI { get; set; }

        // @property (assign, nonatomic) NSInteger scaleDownThreshold;
        [Export("scaleDownThreshold")]
        nint ScaleDownThreshold { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable binarizationModes;
        [NullAllowed, Export("binarizationModes", ArgumentSemantic.Assign)]

        NSObject[] BinarizationModes { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable localizationModes;
        [NullAllowed, Export("localizationModes", ArgumentSemantic.Assign)]

        NSObject[] LocalizationModes { get; set; }

        // @property (assign, nonatomic) EnumIntermediateResultSavingMode intermediateResultSavingMode;
        [Export("intermediateResultSavingMode", ArgumentSemantic.Assign)]
        EnumIntermediateResultSavingMode IntermediateResultSavingMode { get; set; }

        // @property (nonatomic) iFurtherModes * _Nonnull furtherModes;
        [Export("furtherModes", ArgumentSemantic.Assign)]
        iFurtherModes FurtherModes { get; set; }

        // @property (assign, nonatomic) NSInteger deblurLevel;
        [Export("deblurLevel")]
        nint DeblurLevel { get; set; }

        // @property (assign, nonatomic) NSInteger intermediateResultTypes;
        [Export("intermediateResultTypes")]
        nint IntermediateResultTypes { get; set; }

        // @property (assign, nonatomic) EnumResultCoordinateType resultCoordinateType;
        [Export("resultCoordinateType", ArgumentSemantic.Assign)]
        EnumResultCoordinateType ResultCoordinateType { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable textResultOrderModes;
        [NullAllowed, Export("textResultOrderModes", ArgumentSemantic.Assign)]

        NSObject[] TextResultOrderModes { get; set; }

        // @property (nonatomic) iRegionDefinition * _Nonnull region;
        [Export("region", ArgumentSemantic.Assign)]
        iRegionDefinition Region { get; set; }

        // @property (assign, nonatomic) NSInteger minBarcodeTextLength;
        [Export("minBarcodeTextLength")]
        nint MinBarcodeTextLength { get; set; }

        // @property (assign, nonatomic) NSInteger minResultConfidence;
        [Export("minResultConfidence")]
        nint MinResultConfidence { get; set; }

        // @property (assign, nonatomic) NSInteger returnBarcodeZoneClarity;
        [Export("returnBarcodeZoneClarity")]
        nint ReturnBarcodeZoneClarity { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable scaleUpModes;
        [NullAllowed, Export("scaleUpModes", ArgumentSemantic.Assign)]

        NSObject[] ScaleUpModes { get; set; }

        // @property (assign, nonatomic) EnumPDFReadingMode pdfReadingMode;
        [Export("pdfReadingMode", ArgumentSemantic.Assign)]
        EnumPDFReadingMode PdfReadingMode { get; set; }

        // @property (readwrite, nonatomic) NSArray * _Nullable deblurModes;
        [NullAllowed, Export("deblurModes", ArgumentSemantic.Assign)]

        NSObject[] DeblurModes { get; set; }

        // @property (assign, nonatomic) NSInteger barcodeZoneMinDistanceToImageBorders;
        [Export("barcodeZoneMinDistanceToImageBorders")]
        nint BarcodeZoneMinDistanceToImageBorders { get; set; }
    }

    // @interface iSamplingImageData : NSObject
    [BaseType(typeof(NSObject))]
    interface iSamplingImageData
    {
        // @property (nonatomic) NSData * _Nullable bytes;
        [NullAllowed, Export("bytes", ArgumentSemantic.Assign)]
        NSData Bytes { get; set; }

        // @property (assign, nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; set; }

        // @property (assign, nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; set; }
    }

    // @interface iExtendedResult : NSObject
    [BaseType(typeof(NSObject))]
    interface iExtendedResult
    {
        // @property (assign, nonatomic) EnumResultType resultType;
        [Export("resultType", ArgumentSemantic.Assign)]
        EnumResultType ResultType { get; set; }

        // @property (assign, nonatomic) EnumBarcodeFormat barcodeFormat;
        [Export("barcodeFormat", ArgumentSemantic.Assign)]
        EnumBarcodeFormat BarcodeFormat { get; set; }

        // @property (nonatomic) NSString * _Nullable barcodeFormatString;
        [NullAllowed, Export("barcodeFormatString")]
        string BarcodeFormatString { get; set; }

        // @property (assign, nonatomic) EnumBarcodeFormat_2 barcodeFormat_2;
        [Export("barcodeFormat_2", ArgumentSemantic.Assign)]
        EnumBarcodeFormat_2 BarcodeFormat_2 { get; set; }

        // @property (nonatomic) NSString * _Nullable barcodeFormatString_2;
        [NullAllowed, Export("barcodeFormatString_2")]
        string BarcodeFormatString_2 { get; set; }

        // @property (assign, nonatomic) NSInteger confidence;
        [Export("confidence")]
        nint Confidence { get; set; }

        // @property (nonatomic) NSData * _Nullable bytes;
        [NullAllowed, Export("bytes", ArgumentSemantic.Assign)]
        NSData Bytes { get; set; }

        // @property (nonatomic) NSData * _Nullable accompanyingTextBytes;
        [NullAllowed, Export("accompanyingTextBytes", ArgumentSemantic.Assign)]
        NSData AccompanyingTextBytes { get; set; }

        // @property (assign, nonatomic) NSInteger deformation;
        [Export("deformation")]
        nint Deformation { get; set; }

        // @property (nonatomic) NSObject * _Nullable detailedResult;
        [NullAllowed, Export("detailedResult", ArgumentSemantic.Assign)]
        NSObject DetailedResult { get; set; }

        // @property (nonatomic) iSamplingImageData * _Nullable samplingImage;
        [NullAllowed, Export("samplingImage", ArgumentSemantic.Assign)]
        iSamplingImageData SamplingImage { get; set; }

        // @property (assign, nonatomic) NSInteger clarity;
        [Export("clarity")]
        nint Clarity { get; set; }
    }

    // @interface iLocalizationResult : NSObject
    [BaseType(typeof(NSObject))]
    interface iLocalizationResult
    {
        // @property (assign, nonatomic) EnumTerminatePhase terminatePhase;
        [Export("terminatePhase", ArgumentSemantic.Assign)]
        EnumTerminatePhase TerminatePhase { get; set; }

        // @property (assign, nonatomic) EnumBarcodeFormat barcodeFormat;
        [Export("barcodeFormat", ArgumentSemantic.Assign)]
        EnumBarcodeFormat BarcodeFormat { get; set; }

        // @property (nonatomic) NSString * _Nullable barcodeFormatString;
        [NullAllowed, Export("barcodeFormatString")]
        string BarcodeFormatString { get; set; }

        // @property (assign, nonatomic) EnumBarcodeFormat_2 barcodeFormat_2;
        [Export("barcodeFormat_2", ArgumentSemantic.Assign)]
        EnumBarcodeFormat_2 BarcodeFormat_2 { get; set; }

        // @property (nonatomic) NSString * _Nullable barcodeFormatString_2;
        [NullAllowed, Export("barcodeFormatString_2")]
        string BarcodeFormatString_2 { get; set; }

        // @property (nonatomic) NSArray * _Nullable resultPoints;
        [NullAllowed, Export("resultPoints", ArgumentSemantic.Assign)]

        NSObject[] ResultPoints { get; set; }

        // @property (assign, nonatomic) NSInteger angle;
        [Export("angle")]
        nint Angle { get; set; }

        // @property (assign, nonatomic) NSInteger moduleSize;
        [Export("moduleSize")]
        nint ModuleSize { get; set; }

        // @property (assign, nonatomic) NSInteger pageNumber;
        [Export("pageNumber")]
        nint PageNumber { get; set; }

        // @property (nonatomic) NSString * _Nullable regionName;
        [NullAllowed, Export("regionName")]
        string RegionName { get; set; }

        // @property (nonatomic) NSString * _Nullable documentName;
        [NullAllowed, Export("documentName")]
        string DocumentName { get; set; }

        // @property (assign, nonatomic) EnumResultCoordinateType resultCoordinateType;
        [Export("resultCoordinateType", ArgumentSemantic.Assign)]
        EnumResultCoordinateType ResultCoordinateType { get; set; }

        // @property (nonatomic) NSData * _Nullable accompanyingTextBytes;
        [NullAllowed, Export("accompanyingTextBytes", ArgumentSemantic.Assign)]
        NSData AccompanyingTextBytes { get; set; }

        // @property (assign, nonatomic) NSInteger confidence;
        [Export("confidence")]
        nint Confidence { get; set; }
    }

    // @interface iTextResult : NSObject
    [BaseType(typeof(NSObject))]
    interface iTextResult
    {
        // @property (assign, nonatomic) EnumBarcodeFormat barcodeFormat;
        [Export("barcodeFormat", ArgumentSemantic.Assign)]
        EnumBarcodeFormat BarcodeFormat { get; set; }

        // @property (nonatomic) NSString * _Nullable barcodeFormatString;
        [NullAllowed, Export("barcodeFormatString")]
        string BarcodeFormatString { get; set; }

        // @property (assign, nonatomic) EnumBarcodeFormat_2 barcodeFormat_2;
        [Export("barcodeFormat_2", ArgumentSemantic.Assign)]
        EnumBarcodeFormat_2 BarcodeFormat_2 { get; set; }

        // @property (nonatomic) NSString * _Nullable barcodeFormatString_2;
        [NullAllowed, Export("barcodeFormatString_2")]
        string BarcodeFormatString_2 { get; set; }

        // @property (nonatomic) NSString * _Nullable barcodeText;
        [NullAllowed, Export("barcodeText")]
        string BarcodeText { get; set; }

        // @property (nonatomic) NSData * _Nullable barcodeBytes;
        [NullAllowed, Export("barcodeBytes", ArgumentSemantic.Assign)]
        NSData BarcodeBytes { get; set; }

        // @property (nonatomic) iLocalizationResult * _Nullable localizationResult;
        [NullAllowed, Export("localizationResult", ArgumentSemantic.Assign)]
        iLocalizationResult LocalizationResult { get; set; }

        // @property (nonatomic) NSObject * _Nullable detailedResult;
        [NullAllowed, Export("detailedResult", ArgumentSemantic.Assign)]
        NSObject DetailedResult { get; set; }

        // @property (nonatomic) NSArray<iExtendedResult *> * _Nullable extendedResults;
        [NullAllowed, Export("extendedResults", ArgumentSemantic.Assign)]
        iExtendedResult[] ExtendedResults { get; set; }

        // @property (nonatomic) NSString * _Nullable exception;
        [NullAllowed, Export("exception")]
        string Exception { get; set; }

        // @property (assign, nonatomic) NSInteger isDPM;
        [Export("isDPM")]
        nint IsDPM { get; set; }

        // @property (assign, nonatomic) NSInteger isMirrored;
        [Export("isMirrored")]
        nint IsMirrored { get; set; }
    }

    // @interface iOneDCodeDetails : NSObject
    [BaseType(typeof(NSObject))]
    interface iOneDCodeDetails
    {
        // @property (assign, nonatomic) NSInteger moduleSize;
        [Export("moduleSize")]
        nint ModuleSize { get; set; }

        // @property (nonatomic) NSData * _Nullable startCharsBytes;
        [NullAllowed, Export("startCharsBytes", ArgumentSemantic.Assign)]
        NSData StartCharsBytes { get; set; }

        // @property (nonatomic) NSData * _Nullable stopCharsBytes;
        [NullAllowed, Export("stopCharsBytes", ArgumentSemantic.Assign)]
        NSData StopCharsBytes { get; set; }

        // @property (nonatomic) NSData * _Nullable checkDigitBytes;
        [NullAllowed, Export("checkDigitBytes", ArgumentSemantic.Assign)]
        NSData CheckDigitBytes { get; set; }

        // @property (nonatomic) NSArray * _Nonnull startPatternRange;
        [Export("startPatternRange", ArgumentSemantic.Assign)]

        NSObject[] StartPatternRange { get; set; }

        // @property (nonatomic) NSArray * _Nonnull middlePatternRange;
        [Export("middlePatternRange", ArgumentSemantic.Assign)]

        NSObject[] MiddlePatternRange { get; set; }

        // @property (nonatomic) NSArray * _Nonnull endPatternRange;
        [Export("endPatternRange", ArgumentSemantic.Assign)]

        NSObject[] EndPatternRange { get; set; }
    }

    // @interface iQRCodeDetails : NSObject
    [BaseType(typeof(NSObject))]
    interface iQRCodeDetails
    {
        // @property (assign, nonatomic) NSInteger moduleSize;
        [Export("moduleSize")]
        nint ModuleSize { get; set; }

        // @property (assign, nonatomic) NSInteger rows;
        [Export("rows")]
        nint Rows { get; set; }

        // @property (assign, nonatomic) NSInteger columns;
        [Export("columns")]
        nint Columns { get; set; }

        // @property (assign, nonatomic) EnumQRCodeErrorCorrectionLevel errorCorrectionLevel;
        [Export("errorCorrectionLevel", ArgumentSemantic.Assign)]
        EnumQRCodeErrorCorrectionLevel ErrorCorrectionLevel { get; set; }

        // @property (assign, nonatomic) NSInteger version;
        [Export("version")]
        nint Version { get; set; }

        // @property (assign, nonatomic) NSInteger model;
        [Export("model")]
        nint Model { get; set; }

        // @property (assign, nonatomic) NSInteger mode;
        [Export("mode")]
        nint Mode { get; set; }

        // @property (assign, nonatomic) NSInteger page;
        [Export("page")]
        nint Page { get; set; }

        // @property (assign, nonatomic) NSInteger totalPage;
        [Export("totalPage")]
        nint TotalPage { get; set; }

        // @property (assign, nonatomic) Byte parityData;
        [Export("parityData")]
        byte ParityData { get; set; }
    }

    // @interface iPDF417Details : NSObject
    [BaseType(typeof(NSObject))]
    interface iPDF417Details
    {
        // @property (assign, nonatomic) NSInteger moduleSize;
        [Export("moduleSize")]
        nint ModuleSize { get; set; }

        // @property (assign, nonatomic) NSInteger rows;
        [Export("rows")]
        nint Rows { get; set; }

        // @property (assign, nonatomic) NSInteger columns;
        [Export("columns")]
        nint Columns { get; set; }

        // @property (assign, nonatomic) NSInteger errorCorrectionLevel;
        [Export("errorCorrectionLevel")]
        nint ErrorCorrectionLevel { get; set; }
    }

    // @interface iDataMatrixDetails : NSObject
    [BaseType(typeof(NSObject))]
    interface iDataMatrixDetails
    {
        // @property (assign, nonatomic) NSInteger moduleSize;
        [Export("moduleSize")]
        nint ModuleSize { get; set; }

        // @property (assign, nonatomic) NSInteger rows;
        [Export("rows")]
        nint Rows { get; set; }

        // @property (assign, nonatomic) NSInteger columns;
        [Export("columns")]
        nint Columns { get; set; }

        // @property (assign, nonatomic) NSInteger dataRegionRows;
        [Export("dataRegionRows")]
        nint DataRegionRows { get; set; }

        // @property (assign, nonatomic) NSInteger dataRegionColumns;
        [Export("dataRegionColumns")]
        nint DataRegionColumns { get; set; }

        // @property (assign, nonatomic) NSInteger dataRegionNumber;
        [Export("dataRegionNumber")]
        nint DataRegionNumber { get; set; }
    }

    // @interface iAztecDetails : NSObject
    [BaseType(typeof(NSObject))]
    interface iAztecDetails
    {
        // @property (assign, nonatomic) NSInteger moduleSize;
        [Export("moduleSize")]
        nint ModuleSize { get; set; }

        // @property (assign, nonatomic) NSInteger rows;
        [Export("rows")]
        nint Rows { get; set; }

        // @property (assign, nonatomic) NSInteger columns;
        [Export("columns")]
        nint Columns { get; set; }

        // @property (assign, nonatomic) NSInteger layerNumber;
        [Export("layerNumber")]
        nint LayerNumber { get; set; }
    }

    // @interface iIntermediateResult : NSObject
    [BaseType(typeof(NSObject))]
    interface iIntermediateResult
    {
        // @property (assign, nonatomic) NSInteger resultsCount;
        [Export("resultsCount")]
        nint ResultsCount { get; set; }

        // @property (nonatomic) NSObject * _Nullable results;
        [NullAllowed, Export("results", ArgumentSemantic.Assign)]
        NSObject Results { get; set; }

        // @property (assign, nonatomic) EnumIMResultDataType dataType;
        [Export("dataType", ArgumentSemantic.Assign)]
        EnumIMResultDataType DataType { get; set; }

        // @property (assign, nonatomic) EnumIntermediateResultType resultType;
        [Export("resultType", ArgumentSemantic.Assign)]
        EnumIntermediateResultType ResultType { get; set; }

        // @property (assign, nonatomic) EnumBarcodeComplementMode barcodeComplementMode;
        [Export("barcodeComplementMode", ArgumentSemantic.Assign)]
        EnumBarcodeComplementMode BarcodeComplementMode { get; set; }

        // @property (assign, nonatomic) NSInteger bcmIndex;
        [Export("bcmIndex")]
        nint BcmIndex { get; set; }

        // @property (assign, nonatomic) EnumDeformationResistingMode deformationResistingMode;
        [Export("deformationResistingMode", ArgumentSemantic.Assign)]
        EnumDeformationResistingMode DeformationResistingMode { get; set; }

        // @property (assign, nonatomic) NSInteger drmIndex;
        [Export("drmIndex")]
        nint DrmIndex { get; set; }

        // @property (assign, nonatomic) EnumDPMCodeReadingMode dpmCodeReadingMode;
        [Export("dpmCodeReadingMode", ArgumentSemantic.Assign)]
        EnumDPMCodeReadingMode DpmCodeReadingMode { get; set; }

        // @property (assign, nonatomic) NSInteger dpmcrmIndex;
        [Export("dpmcrmIndex")]
        nint DpmcrmIndex { get; set; }

        // @property (nonatomic) NSArray * _Nonnull transformationMatrix;
        [Export("transformationMatrix", ArgumentSemantic.Assign)]

        NSObject[] TransformationMatrix { get; set; }

        // @property (assign, nonatomic) EnumTextFilterMode textFilterMode;
        [Export("textFilterMode", ArgumentSemantic.Assign)]
        EnumTextFilterMode TextFilterMode { get; set; }

        // @property (assign, nonatomic) NSInteger tfmIndex;
        [Export("tfmIndex")]
        nint TfmIndex { get; set; }

        // @property (assign, nonatomic) EnumLocalizationMode localizationMode;
        [Export("localizationMode", ArgumentSemantic.Assign)]
        EnumLocalizationMode LocalizationMode { get; set; }

        // @property (assign, nonatomic) NSInteger lmIndex;
        [Export("lmIndex")]
        nint LmIndex { get; set; }

        // @property (assign, nonatomic) EnumBinarizationMode binarizationMode;
        [Export("binarizationMode", ArgumentSemantic.Assign)]
        EnumBinarizationMode BinarizationMode { get; set; }

        // @property (assign, nonatomic) NSInteger bmIndex;
        [Export("bmIndex")]
        nint BmIndex { get; set; }

        // @property (assign, nonatomic) EnumImagePreprocessingMode imagePreprocessingMode;
        [Export("imagePreprocessingMode", ArgumentSemantic.Assign)]
        EnumImagePreprocessingMode ImagePreprocessingMode { get; set; }

        // @property (assign, nonatomic) NSInteger ipmIndex;
        [Export("ipmIndex")]
        nint IpmIndex { get; set; }

        // @property (assign, nonatomic) NSInteger roiId;
        [Export("roiId")]
        nint RoiId { get; set; }

        // @property (assign, nonatomic) EnumRegionPredetectionMode regionPredetectionMode;
        [Export("regionPredetectionMode", ArgumentSemantic.Assign)]
        EnumRegionPredetectionMode RegionPredetectionMode { get; set; }

        // @property (assign, nonatomic) NSInteger rpmIndex;
        [Export("rpmIndex")]
        nint RpmIndex { get; set; }

        // @property (assign, nonatomic) EnumGrayscaleTransformationMode grayscaleTransformationMode;
        [Export("grayscaleTransformationMode", ArgumentSemantic.Assign)]
        EnumGrayscaleTransformationMode GrayscaleTransformationMode { get; set; }

        // @property (assign, nonatomic) NSInteger gtmIndex;
        [Export("gtmIndex")]
        nint GtmIndex { get; set; }

        // @property (assign, nonatomic) EnumColourConversionMode colourConversionMode;
        [Export("colourConversionMode", ArgumentSemantic.Assign)]
        EnumColourConversionMode ColourConversionMode { get; set; }

        // @property (assign, nonatomic) NSInteger cicmIndex;
        [Export("cicmIndex")]
        nint CicmIndex { get; set; }

        // @property (assign, nonatomic) EnumColourClusteringMode colourClusteringMode;
        [Export("colourClusteringMode", ArgumentSemantic.Assign)]
        EnumColourClusteringMode ColourClusteringMode { get; set; }

        // @property (assign, nonatomic) NSInteger ccmIndex;
        [Export("ccmIndex")]
        nint CcmIndex { get; set; }

        // @property (assign, nonatomic) NSInteger scaleDownRatio;
        [Export("scaleDownRatio")]
        nint ScaleDownRatio { get; set; }

        // @property (assign, nonatomic) NSInteger frameId;
        [Export("frameId")]
        nint FrameId { get; set; }

        // @property (assign, nonatomic) NSInteger rpmColourArgumentIndex;
        [Export("rpmColourArgumentIndex")]
        nint RpmColourArgumentIndex { get; set; }
    }

    // @interface iQuadrilateral : NSObject
    [BaseType(typeof(NSObject))]
    interface iQuadrilateral
    {
        // @property (nonatomic) NSArray * _Nonnull points;
        [Export("points", ArgumentSemantic.Assign)]

        NSObject[] Points { get; set; }
    }

    // @interface iContour : NSObject
    [BaseType(typeof(NSObject))]
    interface iContour
    {
        // @property (assign, nonatomic) NSInteger pointsCount;
        [Export("pointsCount")]
        nint PointsCount { get; set; }

        // @property (nonatomic) NSArray * _Nonnull points;
        [Export("points", ArgumentSemantic.Assign)]

        NSObject[] Points { get; set; }
    }

    // @interface iImageData : NSObject
    [BaseType(typeof(NSObject))]
    interface iImageData
    {
        // @property (nonatomic) NSData * _Nonnull bytes;
        [Export("bytes", ArgumentSemantic.Assign)]
        NSData Bytes { get; set; }

        // @property (assign, nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; set; }

        // @property (assign, nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; set; }

        // @property (assign, nonatomic) NSInteger stride;
        [Export("stride")]
        nint Stride { get; set; }

        // @property (assign, nonatomic) EnumImagePixelFormat format;
        [Export("format", ArgumentSemantic.Assign)]
        EnumImagePixelFormat Format { get; set; }

        // @property (assign, nonatomic) NSInteger orientation;
        [Export("orientation")]
        nint Orientation { get; set; }

        // -(UIImage * _Nullable)toUIImage:(NSError * _Nullable * _Nullable)error;
        [Export("toUIImage:")]
        [return: NullAllowed]
        UIImage ToUIImage([NullAllowed] out NSError error);
    }

    // @interface iLineSegment : NSObject
    [BaseType(typeof(NSObject))]
    interface iLineSegment
    {
        // @property (assign, nonatomic) CGPoint startPoint;
        [Export("startPoint", ArgumentSemantic.Assign)]
        CGPoint StartPoint { get; set; }

        // @property (assign, nonatomic) CGPoint endPoint;
        [Export("endPoint", ArgumentSemantic.Assign)]
        CGPoint EndPoint { get; set; }

        // @property (nonatomic) NSData * _Nullable linesConfidenceCoefficients;
        [NullAllowed, Export("linesConfidenceCoefficients", ArgumentSemantic.Assign)]
        NSData LinesConfidenceCoefficients { get; set; }
    }

    // @interface iRegionOfInterest : NSObject
    [BaseType(typeof(NSObject))]
    interface iRegionOfInterest
    {
        // @property (assign, nonatomic) NSInteger roiId;
        [Export("roiId")]
        nint RoiId { get; set; }

        // @property (assign, nonatomic) CGPoint point;
        [Export("point", ArgumentSemantic.Assign)]
        CGPoint Point { get; set; }

        // @property (assign, nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; set; }

        // @property (assign, nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; set; }
    }

    // @protocol DBRTextResultListener <NSObject>
    /*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
    //[Protocol]
    [BaseType(typeof(NSObject))]
    [Model]
    interface DBRTextResultListener
    {
        // @required -(void)textResultCallback:(NSInteger)frameId imageData:(iImageData * _Nonnull)imageData results:(NSArray<iTextResult *> * _Nullable)results;
        [Abstract]
        [Export("textResultCallback:imageData:results:")]
        void TextResultCallback(nint frameId, iImageData imageData, [NullAllowed] iTextResult[] results);
    }

    // @protocol DBRIntermediateResultListener <NSObject>
    /*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
    [BaseType(typeof(NSObject))]
    [Model]
    interface DBRIntermediateResultListener
    {
        // @required -(void)intermediateResultCallback:(NSInteger)frameId imageData:(iImageData * _Nonnull)imageData results:(NSArray<iIntermediateResult *> * _Nullable)results;
        [Abstract]
        [Export("intermediateResultCallback:imageData:results:")]
        void IntermediateResultCallback(nint frameId, iImageData imageData, [NullAllowed] iIntermediateResult[] results);
    }

    // @protocol DBRLicenseVerificationListener <NSObject>
    /*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
    [BaseType(typeof(NSObject))]
    [Model]
    interface DBRLicenseVerificationListener
    {
        // @required -(void)DBRLicenseVerificationCallback:(_Bool)isSuccess error:(NSError * _Nullable)error;
        [Abstract]
        [Export("DBRLicenseVerificationCallback:error:")]
        void DBRLicenseVerificationCallback(bool isSuccess, [NullAllowed] NSError error);
    }

    // @protocol ImageSource <NSObject>
    /*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
    [BaseType(typeof(NSObject))]
    [Model]
    interface ImageSource
    {
        // @required -(iImageData * _Nullable)getImage;
        [Abstract]
        [NullAllowed, Export("getImage")]
        iImageData Image { get; }
    }

    // @interface DynamsoftBarcodeReader : NSObject
    [BaseType(typeof(NSObject))]
    interface DynamsoftBarcodeReader
    {
        // @property (assign, nonatomic) BOOL enableResultVerification;
        [Export("enableResultVerification")]
        bool EnableResultVerification { get; set; }

        // @property (assign, nonatomic) BOOL enableDuplicateFilter;
        [Export("enableDuplicateFilter")]
        bool EnableDuplicateFilter { get; set; }

        // +(void)initLicense:(NSString * _Nonnull)license verificationDelegate:(id<DBRLicenseVerificationListener> _Nonnull)listener __attribute__((swift_name("initLicense(_:verificationDelegate:)")));
        [Static]
        [Export("initLicense:verificationDelegate:")]
        void InitLicense(string license, [NullAllowed] NSObject listener);

        // -(NSString * _Nullable)outputLicenseToString:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("Will be removed in dbr10.0 release.")));
        [Export("outputLicenseToString:")]
        [return: NullAllowed]
        string OutputLicenseToString([NullAllowed] out NSError error);

        // +(NSString * _Nullable)getVersion;
        [Static]
        [NullAllowed, Export("getVersion")]
        string Version { get; }

        // -(iPublicRuntimeSettings * _Nullable)getRuntimeSettings:(NSError * _Nullable * _Nullable)error;
        [Export("getRuntimeSettings:")]
        [return: NullAllowed]
        iPublicRuntimeSettings GetRuntimeSettings([NullAllowed] out NSError error);

        // -(BOOL)updateRuntimeSettings:(iPublicRuntimeSettings * _Nonnull)settings error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("updateRuntimeSettings(_:)")));
        [Export("updateRuntimeSettings:error:")]
        bool UpdateRuntimeSettings(iPublicRuntimeSettings settings, [NullAllowed] out NSError error);

        // -(BOOL)resetRuntimeSettings:(NSError * _Nullable * _Nullable)error;
        [Export("resetRuntimeSettings:")]
        bool ResetRuntimeSettings([NullAllowed] out NSError error);

        // -(BOOL)setModeArgument:(NSString * _Nonnull)modeName index:(NSInteger)index argumentName:(NSString * _Nonnull)argumentName argumentValue:(NSString * _Nonnull)argumentValue error:(NSError * _Nullable * _Nullable)error;
        [Export("setModeArgument:index:argumentName:argumentValue:error:")]
        bool SetModeArgument(string modeName, nint index, string argumentName, string argumentValue, [NullAllowed] out NSError error);

        // -(NSString *)getModeArgument:(NSString * _Nonnull)modeName index:(NSInteger)index argumentName:(NSString * _Nonnull)argumentName error:(NSError * _Nullable * _Nullable)error;
        [Export("getModeArgument:index:argumentName:error:")]
        string GetModeArgument(string modeName, nint index, string argumentName, [NullAllowed] out NSError error);

        // -(NSArray<iTextResult *> * _Nullable)decodeIntermediateResults:(NSArray<iIntermediateResult *> * _Nullable)array error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("decodeIntermediateResults(_:)")));
        [Export("decodeIntermediateResults:error:")]
        [return: NullAllowed]
        iTextResult[] DecodeIntermediateResults([NullAllowed] iIntermediateResult[] array, [NullAllowed] out NSError error);

        // -(NSArray<iTextResult *> * _Nullable)decodeBase64:(NSString * _Nonnull)base64 error:(NSError * _Nullable * _Nullable)error;
        [Export("decodeBase64:error:")]
        [return: NullAllowed]
        iTextResult[] DecodeBase64(string base64, [NullAllowed] out NSError error);

        // -(NSArray<iTextResult *> * _Nullable)decodeImage:(UIImage * _Nonnull)image error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("decodeImage(_:)")));
        [Export("decodeImage:error:")]
        [return: NullAllowed]
        iTextResult[] DecodeImage(UIImage image, [NullAllowed] out NSError error);

        // -(NSArray<iTextResult *> * _Nullable)decodeBuffer:(NSData * _Nonnull)buffer withWidth:(NSInteger)width height:(NSInteger)height stride:(NSInteger)stride format:(EnumImagePixelFormat)format error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("decodeBuffer(_:width:height:stride:format:)")));
        [Export("decodeBuffer:withWidth:height:stride:format:error:")]
        [return: NullAllowed]
        iTextResult[] DecodeBuffer(NSData buffer, nint width, nint height, nint stride, EnumImagePixelFormat format, [NullAllowed] out NSError error);

        // -(NSArray<iTextResult *> * _Nullable)decodeFileWithName:(NSString * _Nonnull)path error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("decodeFileWithName(_:)")));
        [Export("decodeFileWithName:error:")]
        [return: NullAllowed]
        iTextResult[] DecodeFileWithName(string path, [NullAllowed] out NSError error);

        // -(NSArray<NSString *> * _Nullable)allParameterTemplateNames:(NSError * _Nullable * _Nullable)error;
        [Export("allParameterTemplateNames:")]
        [return: NullAllowed]
        string[] AllParameterTemplateNames([NullAllowed] out NSError error);

        // -(BOOL)initRuntimeSettingsWithFile:(NSString * _Nonnull)fileName conflictMode:(EnumConflictMode)conflictMode error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("initRuntimeSettingsWithFile(_:conflictMode:)")));
        [Export("initRuntimeSettingsWithFile:conflictMode:error:")]
        bool InitRuntimeSettingsWithFile(string fileName, EnumConflictMode conflictMode, [NullAllowed] out NSError error);

        // -(BOOL)initRuntimeSettingsWithString:(NSString * _Nonnull)content conflictMode:(EnumConflictMode)conflictMode error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("initRuntimeSettingsWithString(_:conflictMode:)")));
        [Export("initRuntimeSettingsWithString:conflictMode:error:")]
        bool InitRuntimeSettingsWithString(string content, EnumConflictMode conflictMode, [NullAllowed] out NSError error);

        // -(BOOL)appendTplFileToRuntimeSettings:(NSString * _Nonnull)fileName conflictMode:(EnumConflictMode)conflictMode error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("appendTplFileToRuntimeSettings(_:conflictMode:)")));
        [Export("appendTplFileToRuntimeSettings:conflictMode:error:")]
        bool AppendTplFileToRuntimeSettings(string fileName, EnumConflictMode conflictMode, [NullAllowed] out NSError error);

        // -(BOOL)appendTplStringToRuntimeSettings:(NSString * _Nonnull)content conflictMode:(EnumConflictMode)conflictMode error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("appendTplStringToRuntimeSettings(_:conflictMode:)")));
        [Export("appendTplStringToRuntimeSettings:conflictMode:error:")]
        bool AppendTplStringToRuntimeSettings(string content, EnumConflictMode conflictMode, [NullAllowed] out NSError error);

        // -(NSString * _Nullable)outputSettingsToString:(NSString * _Nonnull)settingsName error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("outputSettingsToString(_:)")));
        [Export("outputSettingsToString:error:")]
        [return: NullAllowed]
        string OutputSettingsToString(string settingsName, [NullAllowed] out NSError error);

        // -(BOOL)outputSettingsToFile:(NSString * _Nullable)filePath settingsName:(NSString * _Nonnull)settingsName error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("outputSettingsToFile(_:settingsName:)")));
        [Export("outputSettingsToFile:settingsName:error:")]
        bool OutputSettingsToFile([NullAllowed] string filePath, string settingsName, [NullAllowed] out NSError error);

        // -(void)setDBRTextResultListener:(id<DBRTextResultListener> _Nullable)textResultDelegate;
        [Export("setDBRTextResultListener:")]
        void SetDBRTextResultListener([NullAllowed] NSObject textResultDelegate);

        // -(void)setDBRIntermediateResultListener:(id<DBRIntermediateResultListener> _Nullable)intermediateResultDelegate;
        [Export("setDBRIntermediateResultListener:")]
        void SetDBRIntermediateResultListener([NullAllowed] NSObject intermediateResultDelegate);

        // -(NSArray<iIntermediateResult *> * _Nullable)getIntermediateResult:(NSError * _Nullable * _Nullable)error;
        [Export("getIntermediateResult:")]
        [return: NullAllowed]
        iIntermediateResult[] GetIntermediateResult([NullAllowed] out NSError error);

        // -(iIntermediateResult * _Nullable)createIntermediateResult:(EnumIntermediateResultType)type error:(NSError * _Nullable * _Nullable)error;
        [Export("createIntermediateResult:error:")]
        [return: NullAllowed]
        iIntermediateResult CreateIntermediateResult(EnumIntermediateResultType type, [NullAllowed] out NSError error);

        // -(void)setCameraEnhancer:(DynamsoftCameraEnhancer * _Nonnull)cameraInstance;
        [Export("setCameraEnhancer:")]
        void SetCameraEnhancer([NullAllowed] NSObject cameraInstance);

        // -(void)startScanning;
        [Export("startScanning")]
        void StartScanning();

        // -(void)stopScanning;
        [Export("stopScanning")]
        void StopScanning();

        // -(void)updateRuntimeSettings:(EnumPresetTemplate)tpl;
        [Export("updateRuntimeSettings:")]
        void UpdateRuntimeSettings(EnumPresetTemplate tpl);

        // +(BOOL)setDeviceFriendlyName:(NSString * _Nullable)name error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("setDeviceFriendlyName:error:")]
        bool SetDeviceFriendlyName([NullAllowed] string name, [NullAllowed] out NSError error);

        // @property (assign, nonatomic) NSInteger minImageReadingInterval;
        [Export("minImageReadingInterval")]
        nint MinImageReadingInterval { get; set; }

        // -(void)setImageSource:(id<ImageSource> _Nonnull)source;
        [Export("setImageSource:")]
        void SetImageSource([NullAllowed] NSObject source);

        // -(NSArray<iTextResult *> * _Nullable)decodeFileInMemory:(NSData * _Nonnull)buffer error:(NSError * _Nullable * _Nullable)error;
        [Export("decodeFileInMemory:error:")]
        [return: NullAllowed]
        iTextResult[] DecodeFileInMemory(NSData buffer, [NullAllowed] out NSError error);
    }

}
