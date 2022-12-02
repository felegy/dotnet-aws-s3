ARG RELEASE=2022-11-11T03-44-20Z
FROM quay.io/minio/minio:RELEASE.${RELEASE}
WORKDIR /usr/share/pki/ca-trust-source/anchors/ 
COPY [".dev/ca/hvgdev.website.crt", "."]
COPY [".dev/ca/hvgdev.website.pem", "."]
RUN update-ca-trust
WORKDIR /
